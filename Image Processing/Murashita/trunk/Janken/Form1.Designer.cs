namespace Janken
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
            this.textBox_Msg = new System.Windows.Forms.TextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button_Junken = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.numericUpDown_HMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_HMax = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_VMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_VMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_SMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_DefThreshold = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Msg
            // 
            this.textBox_Msg.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Msg.Location = new System.Drawing.Point(19, 27);
            this.textBox_Msg.Name = "textBox_Msg";
            this.textBox_Msg.ReadOnly = true;
            this.textBox_Msg.Size = new System.Drawing.Size(495, 23);
            this.textBox_Msg.TabIndex = 0;
            this.textBox_Msg.Text = "ジャンケンするぞー！";
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Black;
            this.imageBox1.Location = new System.Drawing.Point(18, 56);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(496, 403);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseDown);
            // 
            // button_Junken
            // 
            this.button_Junken.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Junken.Location = new System.Drawing.Point(163, 465);
            this.button_Junken.Name = "button_Junken";
            this.button_Junken.Size = new System.Drawing.Size(237, 56);
            this.button_Junken.TabIndex = 3;
            this.button_Junken.Text = "ジャンケン！";
            this.button_Junken.UseVisualStyleBackColor = true;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(598, 27);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(219, 188);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // numericUpDown_HMin
            // 
            this.numericUpDown_HMin.Location = new System.Drawing.Point(60, 26);
            this.numericUpDown_HMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_HMin.Name = "numericUpDown_HMin";
            this.numericUpDown_HMin.Size = new System.Drawing.Size(77, 19);
            this.numericUpDown_HMin.TabIndex = 4;
            // 
            // numericUpDown_HMax
            // 
            this.numericUpDown_HMax.Location = new System.Drawing.Point(194, 26);
            this.numericUpDown_HMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_HMax.Name = "numericUpDown_HMax";
            this.numericUpDown_HMax.Size = new System.Drawing.Size(77, 19);
            this.numericUpDown_HMax.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_VMax);
            this.groupBox1.Controls.Add(this.numericUpDown_VMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_SMax);
            this.groupBox1.Controls.Add(this.numericUpDown_SMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_HMax);
            this.groupBox1.Controls.Add(this.numericUpDown_HMin);
            this.groupBox1.Location = new System.Drawing.Point(564, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HSV Thresholds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "VMax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "VMin";
            // 
            // numericUpDown_VMax
            // 
            this.numericUpDown_VMax.Location = new System.Drawing.Point(194, 76);
            this.numericUpDown_VMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_VMax.Name = "numericUpDown_VMax";
            this.numericUpDown_VMax.Size = new System.Drawing.Size(77, 19);
            this.numericUpDown_VMax.TabIndex = 13;
            // 
            // numericUpDown_VMin
            // 
            this.numericUpDown_VMin.Location = new System.Drawing.Point(60, 76);
            this.numericUpDown_VMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_VMin.Name = "numericUpDown_VMin";
            this.numericUpDown_VMin.Size = new System.Drawing.Size(77, 19);
            this.numericUpDown_VMin.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "SMax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "SMin";
            // 
            // numericUpDown_SMax
            // 
            this.numericUpDown_SMax.Location = new System.Drawing.Point(194, 51);
            this.numericUpDown_SMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_SMax.Name = "numericUpDown_SMax";
            this.numericUpDown_SMax.Size = new System.Drawing.Size(77, 19);
            this.numericUpDown_SMax.TabIndex = 9;
            // 
            // numericUpDown_SMin
            // 
            this.numericUpDown_SMin.Location = new System.Drawing.Point(60, 51);
            this.numericUpDown_SMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_SMin.Name = "numericUpDown_SMin";
            this.numericUpDown_SMin.Size = new System.Drawing.Size(77, 19);
            this.numericUpDown_SMin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "HMax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "HMin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_DefThreshold);
            this.groupBox2.Location = new System.Drawing.Point(564, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 117);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Janken Thresholds";
            // 
            // textBox_DefThreshold
            // 
            this.textBox_DefThreshold.Location = new System.Drawing.Point(122, 21);
            this.textBox_DefThreshold.Name = "textBox_DefThreshold";
            this.textBox_DefThreshold.Size = new System.Drawing.Size(76, 19);
            this.textBox_DefThreshold.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Defact Threshold";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.button_Junken);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.textBox_Msg);
            this.Name = "Form1";
            this.Text = "Junken";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_HMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Msg;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button_Junken;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown_HMin;
        private System.Windows.Forms.NumericUpDown numericUpDown_HMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_VMax;
        private System.Windows.Forms.NumericUpDown numericUpDown_VMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_SMax;
        private System.Windows.Forms.NumericUpDown numericUpDown_SMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_DefThreshold;
        private System.Windows.Forms.Label label7;
    }
}

