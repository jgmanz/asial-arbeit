using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

//Includes EmguCV Library
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;

namespace Janken
{
    public partial class Form1 : Form
    {
         double HMAX = 20;
         double HMIN = 0;
         double SMAX = 255*1;
         double SMIN = (255*0.2);
         double VMAX = 255*1;
         double VMIN = 255*0.2;

         double GMAX = 1.0;
         double GMIN = 0.85;
         double CMAX = 0.85;
         double CMIN = 0.7;
         double PMAX = 0.7;
         double PMIN = 0.5;

         double DefThreshold = 0.05;

        private enum Hands {ROCK = 1, SCISSORS = 2, PAPER = 3, UNKNOWN = -1};

        private Image<Hsv, byte> CurrentFrame;
        private Image<Hsv, double> FrameAvg;
        private Image<Gray, byte> HandImage;
        private Image<Gray, double> HandBack;
        private Capture Cam;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateParams()
        {
            HMAX = (double)numericUpDown_HMax.Value;
            HMIN = (double)numericUpDown_HMin.Value;
            SMAX = (double)numericUpDown_SMax.Value;
            SMIN = (double)numericUpDown_SMin.Value;
            VMAX = (double)numericUpDown_VMax.Value;
            VMIN = (double)numericUpDown_VMin.Value;

            double.TryParse(textBox_DefThreshold.Text, out DefThreshold);
        }

        private void initForms()
        {
            numericUpDown_HMax.Value = (decimal)HMAX;
            numericUpDown_HMin.Value = (decimal)HMIN;
            numericUpDown_SMax.Value = (decimal)SMAX;
            numericUpDown_SMin.Value = (decimal)SMIN;
            numericUpDown_VMax.Value = (decimal)VMAX;
            numericUpDown_VMin.Value = (decimal)VMIN;

            textBox_DefThreshold.Text = DefThreshold.ToString("0.000");
        }

        //画像から肌色領域を抽出
        private void ExtractSkinColor(Image<Hsv, byte> src, ref Image<Gray, byte> dst)
        {
            //チャンネルごとに分割して閾値処理
            Image<Gray, byte>[] channels = src.Split();
            channels[0] = channels[0].Convert<Byte>(delegate(Byte b) { if (HMAX >= b && b >= HMIN) return 255; else return 0; });
            channels[1] = channels[1].Convert<Byte>(delegate(Byte b) { if (SMAX >= b && b >= SMIN) return 255; else return 0; });
            channels[2] = channels[2].Convert<Byte>(delegate(Byte b) { if (VMAX >= b && b >= VMIN) return 255; else return 0; });
            //各部分空間の積が求める領域
            dst = (channels[0] & channels[1] & channels[2]);
        }

        //
        private Contour<Point> PickupLargestArea(ref Image<Gray, byte> src)
        {
            Contour<Point> contour =  src.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, RETR_TYPE.CV_RETR_EXTERNAL);
            if (contour == null)
            {
                return null;
            }
            double max = 0;
            Contour<Point> largest = contour;
            //最大領域を取得
            while (contour != null)
            {
                if (contour.Area > max)
                {
                    max = contour.Area;
                    largest = contour;
                }
                contour = contour.HNext;
            }
            
            //src内の最大領域のみを抽出
            src.SetZero();
            src.DrawPolyline(largest.ApproxPoly(13).ToArray(), true, new Gray(255), -1);
            return largest.ApproxPoly(13);
        }

        private Hands DecideHand(Contour<Point> contour, out double ratio)
        {
            Seq<Point> convex = contour.GetConvexHull(ORIENTATION.CV_CLOCKWISE);
            ratio = contour.Area / convex.Area;

            if (GMAX >= ratio && ratio >= GMIN)
            {
                return Hands.ROCK;
            }
            else if (CMAX >= ratio && ratio >= CMIN){
                return Hands.SCISSORS;
            }
            else if (PMAX >= ratio && ratio >= PMIN)
            {
                return Hands.PAPER;
            }
            else
            {
                return Hands.UNKNOWN;
            }
        }

        //凸包からのくぼみの数(＝指の股の数)から現在の手がどれであるのかを決める。
        private Hands DecideHandFromDefact(Contour<Point> contour)
        {
            if (contour == null)
            {
                return Hands.UNKNOWN;
            }
            //凸包からのくぼみを取得
            Seq<MCvConvexityDefect> defacts = contour.GetConvexityDefacts(null, ORIENTATION.CV_CLOCKWISE);
            int count = 0;
            for (int i = 0; i < defacts.Count<MCvConvexityDefect>(); i++)
            {
                //領域の長さに対するくぼみの深さを求め、それが一定値以上だったら指の股としてカウント
                double r = defacts.ElementAt<MCvConvexityDefect>(i).Depth / contour.Perimeter;
                if (r > DefThreshold)
                {
                    count++;
                }
            }
            Console.WriteLine("{0:d}個の主要な欠損が見つかりました。", count);
            if (count >= 3)
            {
                return Hands.PAPER;
            }
            else if (2 >= count && count >= 1)
            {
                return Hands.SCISSORS;
            }
            else if (count == 0)
            {
                return Hands.ROCK;
            }
            else
            {
                return Hands.UNKNOWN;
            }
        }

        private void MainLoop()
        {
            CurrentFrame = Cam.QueryFrame().Convert<Hsv, byte>();
            HandImage = new Image<Gray, byte>(CurrentFrame.Size);
            while (!IsDisposed)
            {
                CurrentFrame = Cam.QueryFrame().Convert<Hsv, byte>();
                HandImage.SetZero();

                //肌色領域の抽出
                ExtractSkinColor(CurrentFrame, ref HandImage);

                //ノイズ除去
                HandImage.Erode(20);
                HandImage.Dilate(20);

                imageBox2.Image = HandImage;

                //手の輪郭を抽出し、ジャンケンの手を算出
                Contour<Point> hand_contour = PickupLargestArea(ref HandImage);
                Hands hand = DecideHandFromDefact(hand_contour);
                string msg = "";
                switch (hand)
                {
                    case Hands.PAPER:
                        msg = "パー";
                        break;
                    case Hands.ROCK:
                        msg = "グー";
                        break;
                    case Hands.SCISSORS:
                        msg = "チョキ";
                        break;
                    case Hands.UNKNOWN:
                        msg = "不明。。。";
                        break;
                }

                this.Invoke(new MethodInvoker(delegate() {
                    if (!this.IsDisposed) {
                            textBox_Msg.Text = msg;
                            UpdateParams();
                    }
                }));

                if (hand_contour == null)
                {
                    continue;
                }
                CurrentFrame.DrawPolyline(hand_contour.ToArray(), true, new Hsv(255, 255, 255), 2);
                CurrentFrame.DrawPolyline(hand_contour.GetConvexHull(ORIENTATION.CV_CLOCKWISE).ToArray(), true, new Hsv(50, 100, 50), 1);
                imageBox1.Image = CurrentFrame;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initForms();
            Cam = new Capture(0);
            Thread thread = new Thread(new ThreadStart(MainLoop));
            thread.IsBackground = true;
            thread.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("MouseMove X:{0:d} Y:{1:d}, ImageBox1.Top:{2:d} .Left:{3:d}", e.X, e.Y, imageBox1.Top, imageBox1.Left);
            int px = (int)(CurrentFrame.Width * e.X / imageBox1.Width);
            int py = (int)(CurrentFrame.Height * e.Y / imageBox1.Height);
            Hsv pix = CurrentFrame[py, px];
            Console.WriteLine("PickColor x:{0:d} y:{1:d} HSV({2:f}, {3:f}, {4:f}", px, py, pix.Hue, pix.Satuation, pix.Value);
        }

    }
}
