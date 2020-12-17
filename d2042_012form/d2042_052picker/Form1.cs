using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace d2042_052picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_mouseClick(object sender, MouseEventArgs e)
        {
            String date1;
            DateTime result = dateTimePicker1.Value;
            date1 = result.ToString();
            textBox1.Text = date1;
        }
    }
}
