using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace d2042_072ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("One");
            listBox1.Items.Add("Two");
            listBox1.Items.Add("Three");
            listBox1.Items.Add("Four");

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Selected Option : " + listBox1.Text;
        }
    }
}
