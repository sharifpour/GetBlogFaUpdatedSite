using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogFaSpammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                for (int i = 1; i < 28; i++)
                {
                    listBox1.Items.Add(webBrowser1.Document.GetElementsByTagName("A")[i].GetAttribute("href").ToString());
                }
                pictureBox1.Hide();
            }
            catch
            {
                pictureBox1.Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://learn-site.com");
        } 
    }
}
