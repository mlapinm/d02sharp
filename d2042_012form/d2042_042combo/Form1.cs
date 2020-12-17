using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace d2042_042combo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("One");
            comboBox1.Items.Add("Two");
            comboBox1.Items.Add("Three");
            comboBox1.Items.Add("Four");
            comboBox1.SelectedIndex = 0;
        }
        

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Selected option " + comboBox1.Text;
        }

     }
}
