namespace ChromaKey
{
    partial class ConfigureWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_Preview = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_InternalImage3 = new System.Windows.Forms.Label();
            this.imageBox_Internal4 = new Emgu.CV.UI.ImageBox();
            this.imageBox_Internal3 = new Emgu.CV.UI.ImageBox();
            this.label_InternalImage2 = new System.Windows.Forms.Label();
            this.label_InternalImage1 = new System.Windows.Forms.Label();
            this.imageBox_Internal2 = new Emgu.CV.UI.ImageBox();
            this.imageBox_Internal1 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Initialize = new System.Windows.Forms.Button();
            this.comboBox_ExtractMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_FrameCount = new System.Windows.Forms.NumericUpDown();
            this.imageBox_Camera = new Emgu.CV.UI.ImageBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Browse = new System.Windows.Forms.Button();
            this.textBox_ImageFilePath = new System.Windows.Forms.TextBox();
            this.imageBox_BackgroundImage = new Emgu.CV.UI.ImageBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Internal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Internal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Internal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Internal1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FrameCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Camera)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_BackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Initialize);
            this.tabPage2.Controls.Add(this.checkBox_Preview);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.imageBox_Camera);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "前景認識";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_Preview
            // 
            this.checkBox_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_Preview.AutoSize = true;
            this.checkBox_Preview.Enabled = false;
            this.checkBox_Preview.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Preview.Location = new System.Drawing.Point(15, 595);
            this.checkBox_Preview.Name = "checkBox_Preview";
            this.checkBox_Preview.Size = new System.Drawing.Size(196, 20);
            this.checkBox_Preview.TabIndex = 5;
            this.checkBox_Preview.Text = "Preview foreground extraction";
            this.checkBox_Preview.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_InternalImage3);
            this.groupBox2.Controls.Add(this.imageBox_Internal4);
            this.groupBox2.Controls.Add(this.imageBox_Internal3);
            this.groupBox2.Controls.Add(this.label_InternalImage2);
            this.groupBox2.Controls.Add(this.label_InternalImage1);
            this.groupBox2.Controls.Add(this.imageBox_Internal2);
            this.groupBox2.Controls.Add(this.imageBox_Internal1);
            this.groupBox2.Location = new System.Drawing.Point(650, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 382);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Internal Images";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Internal Image 4:";
            // 
            // label_InternalImage3
            // 
            this.label_InternalImage3.AutoSize = true;
            this.label_InternalImage3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InternalImage3.Location = new System.Drawing.Point(10, 186);
            this.label_InternalImage3.Name = "label_InternalImage3";
            this.label_InternalImage3.Size = new System.Drawing.Size(129, 19);
            this.label_InternalImage3.TabIndex = 13;
            this.label_InternalImage3.Text = "Internal Image 3";
            // 
            // imageBox_Internal4
            // 
            this.imageBox_Internal4.BackColor = System.Drawing.Color.Black;
            this.imageBox_Internal4.Location = new System.Drawing.Point(201, 208);
            this.imageBox_Internal4.Name = "imageBox_Internal4";
            this.imageBox_Internal4.Size = new System.Drawing.Size(160, 114);
            this.imageBox_Internal4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox_Internal4.TabIndex = 12;
            this.imageBox_Internal4.TabStop = false;
            // 
            // imageBox_Internal3
            // 
            this.imageBox_Internal3.BackColor = System.Drawing.Color.Black;
            this.imageBox_Internal3.Location = new System.Drawing.Point(14, 208);
            this.imageBox_Internal3.Name = "imageBox_Internal3";
            this.imageBox_Internal3.Size = new System.Drawing.Size(160, 114);
            this.imageBox_Internal3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox_Internal3.TabIndex = 11;
            this.imageBox_Internal3.TabStop = false;
            // 
            // label_InternalImage2
            // 
            this.label_InternalImage2.AutoSize = true;
            this.label_InternalImage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InternalImage2.Location = new System.Drawing.Point(197, 28);
            this.label_InternalImage2.Name = "label_InternalImage2";
            this.label_InternalImage2.Size = new System.Drawing.Size(135, 19);
            this.label_InternalImage2.TabIndex = 10;
            this.label_InternalImage2.Text = "Internal Image 2:";
            // 
            // label_InternalImage1
            // 
            this.label_InternalImage1.AutoSize = true;
            this.label_InternalImage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InternalImage1.Location = new System.Drawing.Point(10, 28);
            this.label_InternalImage1.Name = "label_InternalImage1";
            this.label_InternalImage1.Size = new System.Drawing.Size(131, 19);
            this.label_InternalImage1.TabIndex = 9;
            this.label_InternalImage1.Text = "Internal Image1:";
            // 
            // imageBox_Internal2
            // 
            this.imageBox_Internal2.BackColor = System.Drawing.Color.Black;
            this.imageBox_Internal2.Location = new System.Drawing.Point(201, 50);
            this.imageBox_Internal2.Name = "imageBox_Internal2";
            this.imageBox_Internal2.Size = new System.Drawing.Size(160, 114);
            this.imageBox_Internal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox_Internal2.TabIndex = 3;
            this.imageBox_Internal2.TabStop = false;
            // 
            // imageBox_Internal1
            // 
            this.imageBox_Internal1.BackColor = System.Drawing.Color.Black;
            this.imageBox_Internal1.Location = new System.Drawing.Point(14, 50);
            this.imageBox_Internal1.Name = "imageBox_Internal1";
            this.imageBox_Internal1.Size = new System.Drawing.Size(160, 114);
            this.imageBox_Internal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox_Internal1.TabIndex = 2;
            this.imageBox_Internal1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBox_ExtractMode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_FrameCount);
            this.groupBox1.Location = new System.Drawing.Point(653, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialize Options";
            // 
            // button_Initialize
            // 
            this.button_Initialize.Location = new System.Drawing.Point(877, 584);
            this.button_Initialize.Name = "button_Initialize";
            this.button_Initialize.Size = new System.Drawing.Size(142, 31);
            this.button_Initialize.TabIndex = 8;
            this.button_Initialize.Text = "Initialize";
            this.button_Initialize.UseVisualStyleBackColor = true;
            this.button_Initialize.Click += new System.EventHandler(this.button_Initialize_Click);
            // 
            // comboBox_ExtractMode
            // 
            this.comboBox_ExtractMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ExtractMode.FormattingEnabled = true;
            this.comboBox_ExtractMode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox_ExtractMode.Items.AddRange(new object[] {
            "単一のフレームから抽出",
            "統計値からばらつきを補正",
            "コードブックを使用"});
            this.comboBox_ExtractMode.Location = new System.Drawing.Point(23, 47);
            this.comboBox_ExtractMode.Name = "comboBox_ExtractMode";
            this.comboBox_ExtractMode.Size = new System.Drawing.Size(244, 20);
            this.comboBox_ExtractMode.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Extract Mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Frame count:";
            // 
            // numericUpDown_FrameCount
            // 
            this.numericUpDown_FrameCount.Location = new System.Drawing.Point(25, 88);
            this.numericUpDown_FrameCount.Name = "numericUpDown_FrameCount";
            this.numericUpDown_FrameCount.Size = new System.Drawing.Size(242, 19);
            this.numericUpDown_FrameCount.TabIndex = 3;
            // 
            // imageBox_Camera
            // 
            this.imageBox_Camera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox_Camera.BackColor = System.Drawing.Color.Black;
            this.imageBox_Camera.Location = new System.Drawing.Point(15, 16);
            this.imageBox_Camera.Name = "imageBox_Camera";
            this.imageBox_Camera.Size = new System.Drawing.Size(617, 563);
            this.imageBox_Camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox_Camera.TabIndex = 2;
            this.imageBox_Camera.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Browse);
            this.tabPage1.Controls.Add(this.textBox_ImageFilePath);
            this.tabPage1.Controls.Add(this.imageBox_BackgroundImage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "合成先";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(353, 20);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(57, 21);
            this.button_Browse.TabIndex = 7;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // textBox_ImageFilePath
            // 
            this.textBox_ImageFilePath.Location = new System.Drawing.Point(8, 22);
            this.textBox_ImageFilePath.Name = "textBox_ImageFilePath";
            this.textBox_ImageFilePath.Size = new System.Drawing.Size(339, 19);
            this.textBox_ImageFilePath.TabIndex = 6;
            // 
            // imageBox_BackgroundImage
            // 
            this.imageBox_BackgroundImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.imageBox_BackgroundImage.Location = new System.Drawing.Point(8, 58);
            this.imageBox_BackgroundImage.Name = "imageBox_BackgroundImage";
            this.imageBox_BackgroundImage.Size = new System.Drawing.Size(402, 382);
            this.imageBox_BackgroundImage.TabIndex = 5;
            this.imageBox_BackgroundImage.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(879, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chroma Key!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConfigureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 722);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConfigureWindow";
            this.Text = "ConfigureWindow";
            this.Load += new System.EventHandler(this.ConfigureWindow_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureWindow_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Internal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Internal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Internal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Internal1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FrameCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_Camera)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_BackgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.TextBox textBox_ImageFilePath;
        private Emgu.CV.UI.ImageBox imageBox_BackgroundImage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBox_Camera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_FrameCount;
        private System.Windows.Forms.ComboBox comboBox_ExtractMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Initialize;
        private System.Windows.Forms.Label label_InternalImage2;
        private System.Windows.Forms.Label label_InternalImage1;
        private Emgu.CV.UI.ImageBox imageBox_Internal2;
        private Emgu.CV.UI.ImageBox imageBox_Internal1;
        private System.Windows.Forms.CheckBox checkBox_Preview;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_InternalImage3;
        private Emgu.CV.UI.ImageBox imageBox_Internal4;
        private Emgu.CV.UI.ImageBox imageBox_Internal3;
    }
}