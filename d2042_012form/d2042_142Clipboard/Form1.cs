using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace d2042_142Clipboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.AllowDrop = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            textBox1.Text = Clipboard.GetText();
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Html))
            {
                // Yes it is, so display it in a text box.
                String s1 = "", s2 = "", s3 = ""; 
                s1 = (String)iData.GetData(DataFormats.Html);

                byte[] bytes = Encoding.Default.GetBytes(s1);
                s2 = Encoding.UTF8.GetString(bytes);

                int a1 = 0, a2 = 0, a3 = 0, a4 = 0;
                a1 = s2.IndexOf("href=\"", 0);
                a1 += 6;
                a2 = s2.IndexOf("\"", a1);
                a3 = a2 + 2;
                a4 = s2.IndexOf("</a>");
                string sh1 = "", sl1 = "";
                sl1 = s2.Substring(a1, a2 - a1);
                sh1 = s2.Substring(a3, a4 - a3);
                s3 = "[" + sh1 + "](" + sl1 + ")";
                textBox1.Text = s3;


            }else if (iData.GetDataPresent(DataFormats.Text, true))
            {
                string s1 = "";
                s1 = Clipboard.GetText();
                textBox1.Text = s1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            Clipboard.SetText(s1);

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {

            if(e.Data.GetDataPresent(DataFormats.Html, false) == true){
                e.Effect = DragDropEffects.All;
 
                String s1 = "", s2 = "", s3 = "";
                s1 = (String)e.Data.GetData(DataFormats.Html);

                byte[] bytes = Encoding.Default.GetBytes(s1);
                s2 = Encoding.UTF8.GetString(bytes);

                int a1 = 0, a2 = 0, a3 = 0, a4 = 0;
                a1 = s2.IndexOf("href=\"", 0);
                a1 += 6;
                a2 = s2.IndexOf("\"", a1);
                a3 = a2 + 2;
                a4 = s2.IndexOf("</a>");
                string sh1 = "", sl1 = "";
                sl1 = s2.Substring(a1, a2 - a1);
                sh1 = s2.Substring(a3, a4 - a3);
                s3 = "[" + sh1 + "](" + sl1 + ")";
                textBox1.Text = s3;

            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
                string s1 = "";
                string[] sl;
                IDataObject e1 = e.Data;
                sl = (string[])e1.GetData(DataFormats.FileDrop);
                foreach (string file in sl)
                {

                    s1 += Path.GetFileName(file);
                    s1 += "\r\n";
                }
                //s1 = dataToString(e1);
                textBox1.Text = s1;


            } else if (e.Data.GetDataPresent(DataFormats.Text, true) == true)
            {
                e.Effect = DragDropEffects.All;
                string s1 = "", s2 = "";

                IDataObject e1 = e.Data;
                
                s1 = e1.GetData(DataFormats.Text).ToString();

                byte[] bytes = Encoding.Default.GetBytes(s1);
                s2 = Encoding.UTF8.GetString(bytes);

                textBox1.Text = s2;
            }
        }

        private string dataToString(IDataObject e1)
        {
            string s1 = "";
            string[] sl;

            sl = e1.GetFormats();
            foreach (string s in sl)
            {
                s1 += s;
                s1 += "\r\n";
                s1 += e1.GetData(s);
                s1 += "\r\n";
            }
            return s1;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
