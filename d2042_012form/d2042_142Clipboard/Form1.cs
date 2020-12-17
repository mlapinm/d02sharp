using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace d2042_142Clipboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            textBox1.Text = Clipboard.GetText();
            IDataObject dob = Clipboard.GetDataObject();
            string[] strs = dob.GetFormats();
            String str2 = "";
            foreach(string str in strs)
            {
                str2 += " " + str;
            }
            textBox1.Text = str2;

        }
    }
}
