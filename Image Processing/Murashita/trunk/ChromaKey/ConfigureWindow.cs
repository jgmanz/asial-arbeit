using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;

namespace ChromaKey
{
    public partial class ConfigureWindow : Form
    {
        public Image<Hsv, byte> SyntheticTarget = null;
        
        //カメラキャプチャ情報
        Capture Camera = null;
        //キャプチャスレッド
        Thread CameraThread = null;
        //現在のフレーム
        Image<Hsv, byte> Frame = null;
        

        public ConfigureWindow()
        {
            InitializeComponent();
        }

        private void ConfigureWindow_Load(object sender, EventArgs e)
        {
            //キャプチャ情報を取得
            Camera = new Capture(0);
            //キャプチャスタート
            CameraThread = new Thread(new ThreadStart(CamerThreadStart));
            CameraThread.Start();
        }



        private void CamerThreadStart()
        {
            Frame = Camera.QueryFrame().Convert<Hsv, byte>();
            Image<Hsv, byte> defImage;
            Image<Hsv, byte> resultImage;
            Image<Gray, byte> channelH = new Image<Gray, byte>(Frame.Size);
            Image<Gray, byte> channelS = new Image<Gray, byte>(Frame.Size);
            Image<Gray, byte> channelV = new Image<Gray, byte>(Frame.Size);
            Image<Gray, byte> mask = new Image<Gray, byte>(Frame.Size);

            int erapsed_time = 0;
            while (!IsDisposed)
            {
                int tmp = System.Environment.TickCount;

                Frame = Camera.QueryFrame().Convert<Hsv, byte>();
                if (checkBox_Preview.Checked)
                {
                    
                }
                else
                {
                    imageBox_Camera.Image = Frame;
                }
                //処理時間を考慮して、FPSが50になるように調整
                erapsed_time = System.Environment.TickCount - tmp;
                if (erapsed_time < 50)
                    Thread.Sleep(50 - erapsed_time);
            }
        }

        private void ConfigureWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Camera.Dispose();
            CameraThread.Abort();
        }

        private void button_Initialize_Click(object sender, EventArgs e)
        {
            doInitialize();
        }

        private void doInitialize()
        {
            return;
        }

        private void doInitializeStaticConstant()
        {
            Cursor = Cursors.WaitCursor;
            //スレッドを一時中断
            CameraThread.Suspend();


            //スレッドを再開
            CameraThread.Resume();
            Cursor = Cursors.Default;
        }

        private void doInitializeCodeBook()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox_ImageFilePath.Text = openFileDialog1.FileName;
                SyntheticTarget = new Image<Hsv, byte>(openFileDialog1.FileName);
                imageBox_BackgroundImage.Image = SyntheticTarget;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

}
