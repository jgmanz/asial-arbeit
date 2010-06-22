namespace TrackerTest
{
    partial class Form1
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

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Msg = new System.Windows.Forms.TextBox();
            this.imageBox_Hist1 = new Emgu.CV.UI.ImageBox();
            this.imageBox_Hist2 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Hist1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Hist2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Black;
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox1.Location = new System.Drawing.Point(8, 43);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(517, 428);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseLeave += new System.EventHandler(this.imageBox1_MouseLeave);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            this.imageBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseDown);
            this.imageBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Histogram 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Histogram 2";
            // 
            // textBox_Msg
            // 
            this.textBox_Msg.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Msg.Location = new System.Drawing.Point(9, 11);
            this.textBox_Msg.Name = "textBox_Msg";
            this.textBox_Msg.ReadOnly = true;
            this.textBox_Msg.Size = new System.Drawing.Size(515, 23);
            this.textBox_Msg.TabIndex = 7;
            this.textBox_Msg.Text = "追跡領域を選択してください。";
            // 
            // imageBox_Hist1
            // 
            this.imageBox_Hist1.BackColor = System.Drawing.Color.Black;
            this.imageBox_Hist1.Location = new System.Drawing.Point(539, 69);
            this.imageBox_Hist1.Name = "imageBox_Hist1";
            this.imageBox_Hist1.Size = new System.Drawing.Size(150, 150);
            this.imageBox_Hist1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox_Hist1.TabIndex = 8;
            this.imageBox_Hist1.TabStop = false;
            // 
            // imageBox_Hist2
            // 
            this.imageBox_Hist2.BackColor = System.Drawing.Color.Black;
            this.imageBox_Hist2.Location = new System.Drawing.Point(543, 289);
            this.imageBox_Hist2.Name = "imageBox_Hist2";
            this.imageBox_Hist2.Size = new System.Drawing.Size(150, 150);
            this.imageBox_Hist2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox_Hist2.TabIndex = 9;
            this.imageBox_Hist2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 481);
            this.Controls.Add(this.imageBox_Hist2);
            this.Controls.Add(this.imageBox_Hist1);
            this.Controls.Add(this.textBox_Msg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Hist1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Hist2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Msg;
        private Emgu.CV.UI.ImageBox imageBox_Hist1;
        private Emgu.CV.UI.ImageBox imageBox_Hist2;
    }
}

