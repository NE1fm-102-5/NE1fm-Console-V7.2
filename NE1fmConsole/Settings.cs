using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Net.Mail;
using System.Net.Http;
using Microsoft.VisualBasic;

namespace NE1fmConsole6
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void closeform()
        {
            this.Close();

            var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        

        private void Close_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            PictureBox1.Select();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            closeform();
        }

        private void closetimer_Tick(object sender, EventArgs e)
        {
            closeform();
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            int time;
            time = Convert.ToInt32(Label4.Text);
            if ((time > -1))
            {
                int newtime = time - 1;
                string timestring = newtime.ToString();
                Label4.Text = (timestring);
                Button2.Text = ("BACK ("
                            + (time + ")"));
            }
        }

        private void Button1_Enter(object sender, EventArgs e)
        {
            PictureBox1.Select();
        }

        private void Button2_Enter(object sender, EventArgs e)
        {
            PictureBox1.Select();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            closeform();
            Form1 f1 = new Form1();
            f1.ConsoleUpdater();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            string link = "https://www.dropbox.com/s/1pyfy9dhe2puj75/ConsoleUpdater.exe?dl=1";
            WebClient wc = new WebClient();
            wc.DownloadFile(link, "C:\\NE1fmConsole\\ConsoleUpdater.exe");
            System.Threading.Thread.Sleep(5000);
            Process.Start("C:\\NE1fmConsole\\ConsoleUpdater.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            Environment.Exit(0);
        }
    }
}
