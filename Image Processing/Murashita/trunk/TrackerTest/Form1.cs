using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

//use EmguCV library;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.Util;


namespace TrackerTest
{
    public partial class Form1 : Form
    {
        private Image<Hsv, byte> CurrentFrame;
        private Capture Cam;
        private Rectangle TrackArea = Rectangle.Empty;
        private DenseHistogram hist_TrackArea;
        private DenseHistogram hist_All;
        private Point ds = Point.Empty, de = Point.Empty;
        private bool OnSettingArea;

        private Point[] ContourPoints;
        private const int SEGMENTS = 50;


        private readonly Object LockObject = new Object();

        public Form1()
        {
            InitializeComponent();
            DenseHistogram h = new DenseHistogram(5, new RangeF(0, 255));
            ContourPoints = new Point[SEGMENTS];
        }

        private void UpdateTrackArea()
        {
            lock (LockObject)
            {
                if (!OnSettingArea)
                {
                    throw new InvalidOperationException("UpdateTrackArea must be called while setting area");
                }
                else if (ds == Point.Empty || de == Point.Empty)
                {
                    return;
                }
                else if (ds.Equals(de))
                {
                    TrackArea = Rectangle.Empty;
                }
                else
                {

                    if (TrackArea == Rectangle.Empty)
                    {
                        TrackArea = new Rectangle();
                    }
                    TrackArea.Location = _getInnerPos(new Point(Math.Min(ds.X, de.X), Math.Min(ds.Y, de.Y)));
                    TrackArea.Size = new Size(_getInnerPos(new Point(Math.Abs(ds.X - de.X), Math.Abs(ds.Y - de.Y))));

                    TrackArea.Width = Math.Min(imageBox1.Image.Size.Width - TrackArea.X - 1, TrackArea.Width);
                    TrackArea.Height = Math.Min(imageBox1.Image.Size.Height - TrackArea.Y - 1, TrackArea.Height);
                }
            }
        }

        private void ResetContourPoints()
        {
            if (TrackArea != Rectangle.Empty)
            {
                lock (LockObject)
                {
                    double a = TrackArea.Width / 2;
                    double b = TrackArea.Height / 2;
                    for (int i = 0; i < SEGMENTS; i++)
                    {
                        int px = TrackArea.X + TrackArea.Width / 2 + (int)(a * Math.Cos(2 * Math.PI * i / SEGMENTS));
                        int py = TrackArea.Y + TrackArea.Height / 2 + (int)(b * Math.Sin(2 * Math.PI * i / SEGMENTS));

                        ContourPoints[i] = new Point(px, py);
                    }
                }
            }
        }

        private Point _getInnerPos(Point p)
        {
            Point ret = new Point();
            ret.X = (int)(imageBox1.Image.Size.Width * p.X / imageBox1.Width);
            ret.Y = (int)(imageBox1.Image.Size.Height * p.Y / imageBox1.Height);
            return ret;
        }

        private void imageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lock (LockObject)
            {
                TrackArea = Rectangle.Empty;
            }
            ds = e.Location;
            OnSettingArea = true;
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (OnSettingArea)
            {
                de = e.Location;
                UpdateTrackArea();
                ResetContourPoints();
                OnSettingArea = false;
                ds = de = Point.Empty;
            }
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (OnSettingArea)
            {
                de = e.Location;
                UpdateTrackArea();
            }
        }

        private void imageBox1_MouseLeave(object sender, EventArgs e)
        {
            if (OnSettingArea)
            {
                UpdateTrackArea();
                ResetContourPoints();
                OnSettingArea = false;
                ds = de = Point.Empty;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Cam = new Capture(0);
            Thread thread = new Thread(new ThreadStart(MainLoop));
            thread.IsBackground = true;
            thread.Start();
        }

        private void CalculateHist()
        {
        }

        private void GetProbImage()
        {

        }

        private void DrawHist2D(Image<Gray, byte> dst, DenseHistogram hist)
        {
            int pw = (int)(dst.Width / hist.BinDimension[0].Size);
            int ph = (int)(dst.Height / hist.BinDimension[1].Size);
            float min, max;
            int[] tmp1, tmp2;
            hist.MinMax(out min, out max, out tmp1, out tmp2); 
            for (int ix = 0; ix < hist.BinDimension[0].Size; ix++ )
            {
                for (int iy = 0; iy < hist.BinDimension[1].Size; iy ++)
                {
                    double intensity = hist[ix, iy] * 255 / max;
                    dst.Draw(new Rectangle(ix * pw, iy * ph, pw, ph), new Gray(intensity), -1);
                }
            }
        }

        private void MainLoop()
        {
            CurrentFrame = Cam.QueryFrame().Convert<Hsv, byte>();
            Image<Gray, byte>[] channels;
            Image<Gray, byte> HistImg1 = new Image<Gray, byte>(500, 500);
            Image<Gray, byte> HistImg2 = new Image<Gray, byte>(500, 500);
            Image<Gray, byte> ProbImage;
            DenseHistogram hist1 = new DenseHistogram(new int[] { 10, 10 }, new RangeF[] { new RangeF(0, 255), new RangeF(0, 255) });
            DenseHistogram hist2 = new DenseHistogram(new int[] { 10, 10 }, new RangeF[] { new RangeF(0, 255), new RangeF(0, 255) });


            MCvConnectedComp comp;
            MCvTermCriteria criteria = new MCvTermCriteria(10, 1);
            MCvBox2D box;

            while (true)
            {
                    CurrentFrame = Cam.QueryFrame().Convert<Hsv, byte>();
                    if (OnSettingArea && TrackArea != Rectangle.Empty)
                    {
                        CurrentFrame.ROI = TrackArea;
                        channels = CurrentFrame.Split();
                        hist1.Calculate(new Image<Gray, byte>[] { channels[0], channels[1] }, false, null);
                        CurrentFrame.Not().CopyTo(CurrentFrame);

                        CurrentFrame.ROI = Rectangle.Empty;
                        CurrentFrame.Draw(TrackArea, new Hsv(100, 100, 100), 2);
                        imageBox1.Image = CurrentFrame;
                    }
                    else
                    {
                        if (TrackArea != Rectangle.Empty)
                        {      
                            channels = CurrentFrame.Split();
                            ProbImage = hist1.BackProject<byte>(new Image<Gray, byte>[] { channels[0], channels[1] });
                            imageBox_Hist2.Image = ProbImage.Convert<Gray, byte>();

                            lock (LockObject)
                            {
                                if (TrackArea.Height * TrackArea.Width > 0)
                                {
                                    CvInvoke.cvCamShift(ProbImage, TrackArea, criteria, out comp, out box);

                                    TrackArea = comp.rect;
                                    CurrentFrame.Draw(box, new Hsv(100, 100, 100), 2);
                                }
                                /**
                                ResetContourPoints();
                                for (int i = 0; i < 60; i++)
                                {
                                    ProbImage.Snake(ContourPoints, (float)1.0, (float)0.5, (float)1.5, new Size(17, 17), criteria, true);
                                }
                                CurrentFrame.DrawPolyline(ContourPoints, true, new Hsv(100, 100, 100), 2);
                                */
                            }
                        }
                        imageBox1.Image = CurrentFrame;
                        //calculate histogram;
                        //channels = CurrentFrame.Split();
                        //hist2.Calculate(new Image<Gray, byte>[] { channels[0], channels[1] }, false, null);
                        //hist2.Normalize(1);
                        //HistImg1.SetZero();
                        //DrawHist2D(HistImg1, hist1);
                        //imageBox_Hist1.Image = HistImg1;
                    }
            }
        }



    }
}
