namespace ChromaKey
{
    partial class AvgExtractor_Panel
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Threshold = new System.Windows.Forms.Label();
            this.label_SamplingCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_SamplingCount = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SamplingCount)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "分散によるノイズ除去";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 48);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(229, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Threshold Coeff :";
            // 
            // label_Threshold
            // 
            this.label_Threshold.AutoSize = true;
            this.label_Threshold.Location = new System.Drawing.Point(131, 32);
            this.label_Threshold.Name = "label_Threshold";
            this.label_Threshold.Size = new System.Drawing.Size(11, 12);
            this.label_Threshold.TabIndex = 3;
            this.label_Threshold.Text = "0";
            // 
            // label_SamplingCount
            // 
            this.label_SamplingCount.AutoSize = true;
            this.label_SamplingCount.Location = new System.Drawing.Point(131, 96);
            this.label_SamplingCount.Name = "label_SamplingCount";
            this.label_SamplingCount.Size = new System.Drawing.Size(11, 12);
            this.label_SamplingCount.TabIndex = 6;
            this.label_SamplingCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sampling Count :";
            // 
            // trackBar_SamplingCount
            // 
            this.trackBar_SamplingCount.Location = new System.Drawing.Point(3, 112);
            this.trackBar_SamplingCount.Maximum = 300;
            this.trackBar_SamplingCount.Minimum = 20;
            this.trackBar_SamplingCount.Name = "trackBar_SamplingCount";
            this.trackBar_SamplingCount.Size = new System.Drawing.Size(229, 45);
            this.trackBar_SamplingCount.TabIndex = 4;
            this.trackBar_SamplingCount.TickFrequency = 10;
            this.trackBar_SamplingCount.Value = 20;
            this.trackBar_SamplingCount.Scroll += new System.EventHandler(this.trackBar_SamplingCount_Scroll);
            // 
            // AvgExtractor_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_SamplingCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar_SamplingCount);
            this.Controls.Add(this.label_Threshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox1);
            this.Name = "AvgExtractor_Panel";
            this.Size = new System.Drawing.Size(262, 197);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SamplingCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Threshold;
        private System.Windows.Forms.Label label_SamplingCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_SamplingCount;
    }
}
