using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChromaKey
{
    public partial class AvgExtractor_Panel : UserControl
    {
        public int ThresholdCoeff
        {
            get
            {
                return this.trackBar1.Value;
            }
            set
            {
                this.trackBar1.Value = (int)value;
            }
        }

        public int SamplingCount
        {
            get
            {
                return this.trackBar_SamplingCount.Value;
            }
            set
            {
                this.trackBar_SamplingCount.Value = (int)value;
            }
        }

        public bool UseVariance
        {
            get
            {
                return this.checkBox1.Checked;
            }
            set
            {
                this.checkBox1.Checked = (bool)value;
            }
        }

        public AvgExtractor_Panel()
        {
            InitializeComponent();
        }

        public AvgExtractor_Panel(bool use_var, int threshold_coeff, int sampling_count)
        {
            InitializeComponent();
            this.UseVariance = use_var;
            this.ThresholdCoeff = threshold_coeff;
            this.SamplingCount = sampling_count;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_Threshold.Text = trackBar1.Value.ToString("0");
        }

        private void trackBar_SamplingCount_Scroll(object sender, EventArgs e)
        {
            label_SamplingCount.Text = trackBar_SamplingCount.Value.ToString("0");
        }
    }
}
