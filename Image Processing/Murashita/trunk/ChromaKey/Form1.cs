using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChromaKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Configure_Click(object sender, EventArgs e)
        {
            using (ConfigureWindow cWindow = new ConfigureWindow())
            {
                cWindow.ShowDialog();
            }
        }
    }
}
