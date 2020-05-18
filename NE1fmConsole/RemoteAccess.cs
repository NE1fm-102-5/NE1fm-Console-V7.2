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
    public partial class RemoteAccess : Form
    {
        public RemoteAccess()
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

        private void Button4_Click(object sender, EventArgs e)
        {
            closeform();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\cmd.exe", " /c echo PLEASE DO NOT CLOSE - Connecting To OtsAV PC... & echo N310T5H34dph0n3s! | \"C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe\" 450130805 --with-password ");
            closeform();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\cmd.exe", " /c echo PLEASE DO NOT CLOSE - Connecting To Logger PC... & echo N31L0gg3r18! | \"C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe\" 400074608 --with-password ");
            closeform();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\cmd.exe", " /c echo PLEASE DO NOT CLOSE - Connecting To Office PC... & echo N310ff1c318! | \"C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe\" 377261915 --with-password ");
            closeform();
        }

        private void RemoteAccess_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            this.TopMost = true;
            RAC.Select();
        }

        private void RemoteAccess_Shown(object sender, EventArgs e)
        {
            if (File.Exists("C:\\NE1fmConsole\\LoggerPC.txt")) 
            {
                RA2.Enabled = false;
            }
            else
            {
                RA2.Enabled = true;
            }

            if (File.Exists("C:\\NE1fmConsole\\OfficePC.txt"))
            {
                RA3.Enabled = false;
            }
            else
            {
                RA3.Enabled = true;
            }
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            int time;
            time = Convert.ToInt32(RAT.Text);
            if (time > -1)
            {
                int newtime = newtime = time - 1;
                RAT.Text = newtime.ToString();
                RAC.Text = ("Back ("+ (time + ")"));
            }
        }

        private void closetimer_Tick(object sender, EventArgs e)
        {
            closeform();
        }

        private void Button1_Enter(object sender, EventArgs e)
        {
            RAC.Select();
        }

        private void Button2_Enter(object sender, EventArgs e)
        {
            RAC.Select();
        }

        private void Button3_Enter(object sender, EventArgs e)
        {
            RAC.Select();
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
