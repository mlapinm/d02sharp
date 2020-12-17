using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace d2042_102ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            for (int i = 0; i < 200; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(80);
            }
        }
    }
}
