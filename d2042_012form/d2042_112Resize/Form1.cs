using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace d2042_112Resize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            this.Size = new System.Drawing.Size(400, 350);
        }
    }
}
