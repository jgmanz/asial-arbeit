using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;

namespace ChromaKey
{
	public abstract class Extractor
	{
        /**
         * <summary>
         * スタートしているかどうか。
         * </summary>
         */
        public bool Started;
        /**
         * <summary>
         * 初期設定パネル
         * </summary>
         */
        public abstract UserControl InitializePanel
        {
            get;
        }
        /**
         * <summary>
         * 内部パラメータをアップデートする。
         * </summary>
         */
        public abstract void UpdateParameters(Image<Bgr, byte> frame);
        /**
         * <summary>
         * フレームから前景を抽出するための、マスク画像を返す。
         * </summary>
         */
        public abstract Image<Gray, byte> GetMask(Image<Bgr, byte> frame);
        /**
         * <summary>
         * 抽出処理を開始する。
         * </summary>
         */
        public abstract void Start();
        /**
         * <summary>
         * 内部パラメータをリセット。
         * </summary>
         */
        public abstract void Reset();
	}

    public class AvgExtractor : Extractor
    {
        private Image<Hsv, double> acc1, sq_acc1, acc2;
        private Image<Hsv, byte> Avg;
        private Image<Hsv, byte> Var;
        private Image<Hsv, byte> Dif;
        private int SamplingCount = 50;
        private int Threshold = 20;
        private int FrameCount;
        private bool UseVariance;
        private AvgExtractor_Panel initPanel;

        public AvgExtractor()
        {
            FrameCount = 0;
            Started = false;
            this.initPanel = new AvgExtractor_Panel(false, Threshold, SamplingCount);
        }

        public override void Start()
        {
            this.SamplingCount = initPanel.SamplingCount;
            this.Threshold = initPanel.ThresholdCoeff;
            this.UseVariance = initPanel.UseVariance;

            this.Started = false;
        }

        public override void UpdateParameters(Image<Bgr, byte> frame)
        {
            if (this.Started)
            {
                if (acc1 == null)
                {
                    acc1 = new Image<Hsv, double>(frame.Size);
                    sq_acc1 = new Image<Hsv, double>(frame.Size);
                    acc2 = new Image<Hsv, double>(frame.Size);
                    CvInvoke.cvSetZero(acc1);
                    CvInvoke.cvSetZero(acc2);
                    CvInvoke.cvSetZero(sq_acc1);
                }

                if (FrameCount < SamplingCount)
                {
                    Image<Hsv, double> frameImage = frame.Convert<Hsv, double>();

                    //平均及び分散の累積画像を更新
                    acc1 = acc1 * FrameCount;
                    acc2 = acc2 * FrameCount;
                    CvInvoke.cvAcc(frameImage, acc1, IntPtr.Zero);
                    CvInvoke.cvSquareAcc(frameImage, acc2, IntPtr.Zero);
                    acc1 = acc1 / (FrameCount + 1);
                    acc2 = acc2 / (FrameCount + 1);

                    Avg = acc1.Convert<Hsv, byte>();
                    CvInvoke.cvSquareAcc(acc1, sq_acc1, IntPtr.Zero);
                    Var = (acc2 - sq_acc1).Convert<Hsv, byte>();
                }
                else
                {
                    return;
                }
            }
        }

        public override Image<Gray, byte> GetMask(Image<Bgr, byte> frame)
        {
            if (this.Started)
            {
                Dif = frame.Convert<Hsv, byte>();
                CvInvoke.cvAbsDiff(Dif, Avg, Dif);
                if (initPanel.UseVariance)
                {
                    CvInvoke.cvSub(Dif, Var * 2, Dif, IntPtr.Zero);
                }
                else
                {
                    CvInvoke.cvSubS(Dif, new MCvScalar(Threshold, Threshold, Threshold), Dif, IntPtr.Zero);
                }
                //mask = defImage.Convert<Gray, byte>();
                //CvInvoke.cvThreshold(mask, mask, 0, 255, Emgu.CV.CvEnum.THRESH.CV_THRESH_BINARY);
                //CvInvoke.cvErode(mask, mask, IntPtr.Zero, 2);
                //CvInvoke.cvDilate(mask, mask, IntPtr.Zero, 2);
            }
            return null;
        }

        public override void Reset()
        {
            if ((acc1 == null || sq_acc1 == null) || acc2 == null)
            {
                throw new Exception("Unexpected error occured. AvgExtractor.Reset called when the parameters hadn't been initialized.");
            }
            else
            {
                CvInvoke.cvSetZero(acc1);
                CvInvoke.cvSetZero(acc2);
                CvInvoke.cvSetZero(sq_acc1);
                FrameCount = 0;
                this.Started = false;
            }
        }

        public override UserControl InitializePanel
        {
            get
            {
                return initPanel; 
            }
        }
    }

    public class CodeBookExtractor : Extractor
    {
        public override void UpdateParameters(Image<Bgr, byte> frame)
        {
        }

        public override Image<Gray, byte> GetMask(Image<Bgr, byte> frame)
        {
            return null;
        }

        public override void Reset()
        {
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override UserControl InitializePanel
        {
            get { throw new NotImplementedException(); }
        }

        public class CodeBook
        {
            public ArrayList Entries = new ArrayList();
            public long Ticks;
        }

        public class CodeElement
        {
            public byte[] learnHigh = new byte[3];
            public byte[] learnLow = new byte[3];
            public byte[] max = new byte[3];
            public byte[] min = new byte[3];
            public long LastUpdate;
            public long Stale;
        }

        public class CodeBookManager
        {
            public static long Time
            {
                get
                {
                    return (DateTime.Now.Ticks);
                }
            }

            public static int UpdateCodeBook(byte[] p, CodeBook cb)
            {
                cb.Ticks = Time;

                byte[] high, low;
                high = new byte[3];
                low = new byte[3];

                for (int i = 0; i < 3; i++)
                {
                    high[i] = (byte)((p[i] + 10 > 255) ? 255 : (p[i] + 10));
                    low[i] = (byte)((p[i] - 10 < 0) ? 0 : (p[i] - 10));
                }

                int matchChannel;
                int matchedIndex = 0;
                for (int i = 0; i < cb.Entries.Count; i++)
                {
                    matchChannel = 0;
                    CodeElement e = (CodeElement)cb.Entries[i];
                    for (int k = 0; k < 3; k++)
                    {
                        if (e.learnLow[k] <= p[k] && e.learnHigh[k] >= p[k])
                        {
                            matchChannel++;
                        }
                    }

                    if (matchChannel == 3)
                    {
                        e.LastUpdate = cb.Ticks;
                        for (int k = 0; k < 3; k++)
                        {
                            if (e.max[k] < p[k])
                            {
                                e.max[k] = p[k];
                            }
                            else if (e.min[k] > p[k])
                            {
                                e.min[k] = p[k];
                            }

                            if (e.learnHigh[k] < high[k]) e.learnHigh[k] += 1;
                            if (e.learnLow[k] < low[k]) e.learnLow[k] -= 1;
                        }
                        matchedIndex = i;
                        break;
                    }

                    if (i == cb.Entries.Count - 1)
                    {
                        matchedIndex = cb.Entries.Count;
                        break;
                    }
                }

                for (int s = 0; s < cb.Entries.Count; s++)
                {
                    CodeElement e = (CodeElement)cb.Entries[s];
                    long negRun = cb.Ticks - e.LastUpdate;
                    if (e.Stale < negRun)
                    {
                        e.Stale = negRun;
                    }
                }

                if (matchedIndex == cb.Entries.Count)
                {
                    CodeElement enew = new CodeElement();
                    for (int k = 0; k < 3; k++)
                    {
                        enew.learnHigh[k] = high[k];
                        enew.learnLow[k] = low[k];
                        enew.max[k] = p[k];
                        enew.min[k] = p[k];
                    }
                    enew.LastUpdate = cb.Ticks;
                    enew.Stale = 0;

                    cb.Entries.Add(enew);
                }

                return matchedIndex;
            }

            public static void UpdateCodeBooks(Image<Hsv, byte> image, CodeBook[,] codebooks)
            {
                if (image.Height == codebooks.GetLength(0) && image.Width == codebooks.GetLength(1))
                {
                    throw new ArgumentException("InvalidArgument");
                }
                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        Hsv p = image[i, j];
                        UpdateCodeBook(new byte[3] { (byte)p.Hue, (byte)p.Satuation, (byte)p.Value }, codebooks[i, j]);
                    }
                }
            }

            public static void ClearStaleEntries(CodeBook[,] cbs)
            {
                //閾値は5秒
                long staleThresh = 5 * 10 ^ 7;
                foreach (CodeBook cb in cbs)
                {
                    for (int i = 0; i < cb.Entries.Count; i++)
                    {
                        CodeElement e = (CodeElement)cb.Entries[i];
                        if (e.Stale > staleThresh)
                        {
                            cb.Entries.RemoveAt(i);
                        }
                    }
                }
            }

            public static CodeBook[,] CreateCodeBook(Image<Hsv, byte> image)
            {
                CodeBook[,] codebooks = new CodeBook[image.Height, image.Width];
                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        codebooks[i, j] = new CodeBook();
                    }
                }
                return codebooks;
            }
        }
    }

}