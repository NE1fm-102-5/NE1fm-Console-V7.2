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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        public void Stats()
        {
            cd.Enabled = false;
            contstream.Enabled = false;
            M1.Enabled = false;
            M1.Text = "Refreshing Data...";
            try
            {
                WebClient webstatus = new WebClient();
                string statusresponse = webstatus.DownloadString("https://ne1fm.radioca.st/stats");
                string status_start = statusresponse.Substring(statusresponse.IndexOf("<STREAMSTATUS>"));
                string status_start_trimmed = status_start.Replace("<STREAMSTATUS>", "");
                string status_end_number = status_start_trimmed.Substring(0, status_start_trimmed.LastIndexOf("</STREAMSTATUS>"));
                int status = Int32.Parse(status_end_number);
                if ((status == 1))
                {
                    WebClient weblisten = new WebClient();
                    string listenresponse = weblisten.DownloadString("https://ne1fm.radioca.st/stats");
                    string list_start = listenresponse.Substring(listenresponse.IndexOf("<CURRENTLISTENERS>"));
                    string list_start_trimmed = list_start.Replace("<CURRENTLISTENERS>", "");
                    string list_end = list_start_trimmed.Substring(0, list_start_trimmed.LastIndexOf("</CURRENTLISTENERS>"));
                    int listeners = Int32.Parse(list_end);
                    if (listeners == 1)
                    {
                        Label22.Text = ("Online" + (" with " + (list_end + " listener")));
                    }
                    else
                    {
                        Label22.Text = ("Online" + (" with " + (list_end + " listeners")));
                    }

                    
                    Label22.ForeColor = Color.Green;
                }

                else
                {
                    Label22.Text = "Offline";
                    Label22.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
            }
            
            string minutetime = DateTime.Now.ToString("mm");
            if (((minutetime == "59")
                        || ((minutetime == "00")
                        || (minutetime == "01"))))
            {
                if ((Label27.Text == "Collecting Information..."))
                {
                    Label27.Text = "Updating Soon - Too Close To The Hour";
                    Label27.ForeColor = Color.DarkBlue;
                }

                Label9.Text = "121";
                M1.Text = "Refresh Data Now (2:00)";
                M1.Enabled = true;
                contstream.Interval = 122000;
                contstream.Enabled = true;
                cd.Enabled = true;
            }
            else
            {
                string lognumber;
                string cachelognumber;
                string logname;
                string cachelognameogg;
                string cachelognametmp;
                string logpath;
                string cachelogpatha;
                string cachelogpathb;
                string hournow;
                hournow = DateTime.Now.ToString("HH");
                string minutenow;
                minutenow = DateTime.Now.ToString("mm");
                lognumber = DateTime.Now.ToString("yyyyMMddHH");
                cachelognumber = DateTime.Now.ToString("yyyyMMddHHmm");
                logname = (lognumber + "0000.ogg");
                cachelognametmp = (cachelognumber + "00.tmp");
                cachelognameogg = (cachelognumber + "00.ogg");
                if (File.Exists("C:\\NE1fmConsole\\OfficePC.txt"))
                {
                    try
                    {
                        logpath = ("\\\\NE1-LOGGER\\Logger\\Store\\" + logname);
                        cachelogpatha = ("\\\\NE1-LOGGER\\Logger\\Cache\\" + cachelognametmp);
                        cachelogpathb = ("\\\\NE1-LOGGER\\Logger\\Cache\\" + cachelognameogg);
                        if (File.Exists(logpath))
                        {
                            Label27.Text = "Recording";
                            Label27.ForeColor = Color.Green;
                            Label8.Visible = false;
                        }
                        else if ((File.Exists(cachelogpatha) || File.Exists(cachelogpathb)))
                        {
                            Label27.Text = "Recording In Minutes";
                            Label27.ForeColor = Color.DarkOrange;
                            Label8.Visible = true;
                        }
                        else
                        {
                            Label27.Text = "Not Recording";
                            Label27.ForeColor = Color.Red;
                            Label8.Visible = true;
                        }

                    }
                    catch (Exception ex)
                    {
                    }

                }
                else if (File.Exists("C:\\NE1fmConsole\\LoggerPC.txt"))
                {
                    logpath = ("C:\\Logger\\Store\\" + logname);
                    cachelogpatha = ("C:\\Logger\\Cache\\" + cachelognametmp);
                    cachelogpathb = ("C:\\Logger\\Cache\\" + cachelognameogg);
                    if (File.Exists(logpath))
                    {
                        Label27.Text = "Recording";
                        Label27.ForeColor = Color.Green;
                        Label8.Visible = false;
                    }
                    else if ((File.Exists(cachelogpatha) || File.Exists(cachelogpathb)))
                    {
                        Label27.Text = "Recording In Minutes";
                        Label27.ForeColor = Color.DarkOrange;
                        Label8.Visible = true;
                    }
                    else
                    {
                        Label27.Text = "Not Recording";
                        Label27.ForeColor = Color.Red;
                        Label8.Visible = true;
                    }
                    
                }
                else
                {
                    Label27.Text = "Unconfigured Environment";
                    Label27.ForeColor = Color.DarkBlue;
                    Label8.Visible = false;
                }

                M1.Enabled = true;
                M1.Text = "Refresh Data Now (5:00)";
                contstream.Interval = 302000;
                contstream.Enabled = true;
                Label9.Text = "301";
                cd.Enabled = true;
            }

        }


        public void ConsoleUpdater()
        {
            try
            {
                File.Delete("C:\\NE1fmConsole\\ConsoleUpdater.exe");
            }
            catch (Exception ex)
            {
            }

            try
            {
                System.Net.WebRequest request = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/s/oe4lzcotlbrktjd/version.txt?insert_anything_you_want");
                System.Net.WebResponse response = request.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream());
                string newestversion = sr.ReadToEnd();
                string currentversion = Application.ProductVersion;
                if (newestversion.Contains(currentversion))
                {
                    // do nothing
                }
                else
                {
                    string link = "https://www.dropbox.com/s/1pyfy9dhe2puj75/ConsoleUpdater.exe?dl=1";
                    WebClient wc = new WebClient();
                    wc.DownloadFile(link, "C:\\NE1fmConsole\\ConsoleUpdater.exe");
                    System.Threading.Thread.Sleep(5000);
                    Process.Start("C:\\NE1fmConsole\\ConsoleUpdater.exe");
                }

            }
            catch (Exception ex)
            {}
        }

        void LogProg()
        {
            try
            {
                if (File.Exists("C:\\NE1fmConsole\\LoggerPC.txt"))
                {
                    Process[] p1;
                    p1 = Process.GetProcessesByName("ALFiler");
                    if ((p1.Length > 0))
                    {
                        // Already Running
                    }
                    else
                    {
                        try
                        {
                            Process.Start("C:\\Logger\\ALFiler.exe");
                        }
                        catch (Exception ex)
                        {
                        }

                    }

                    Process[] p2;
                    p2 = Process.GetProcessesByName("ALRec");
                    if ((p2.Length > 0))
                    {
                        // Already Running
                    }
                    else
                    {
                        try
                        {
                            Process.Start("C:\\Logger\\ALRec.exe");
                        }
                        catch (Exception ex)
                        {
                        }

                    }

                    Process[] p3;
                    p3 = Process.GetProcessesByName("butt");
                    if ((p3.Length > 0))
                    {
                        // Already Running
                    }
                    else
                    {
                        try
                        {
                            Process.Start("C:\\Users\\logger\\AppData\\Local\\butt-0.1.16\\butt.exe");
                        }
                        catch (Exception ex)
                        {
                        }

                    }

                    Process[] p4;
                    p4 = Process.GetProcessesByName("piraside");
                    if ((p4.Length > 0))
                    {
                        // Already Running
                    }
                    else
                    {
                        try
                        {
                            Process.Start("C:\\Program Files (x86)\\Pira CZ Silence Detector\\piraside.exe");
                        }
                        catch (Exception ex)
                        {
                        }

                    }

                    Process[] p5;
                    p5 = Process.GetProcessesByName("Now Playing Tool for OtsAV");
                    if ((p5.Length > 0))
                    {
                        // Already Running
                    }
                    else
                    {
                        try
                        {
                            Process.Start("C:\\Program Files\\Now Playing Tool for OtsAV\\Now Playing Tool for OtsAV.exe");
                        }
                        catch (Exception ex)
                        {
                        }

                    }

                    Process[] p6;
                    p6 = Process.GetProcessesByName("Stats Tool For OtsAV");
                    if ((p6.Length > 0))
                    {
                        // Already Running
                    }
                    else
                    {
                        try
                        {
                            Process.Start("C:\\Program Files\\Stats Tool for OtsAV\\Stats Tool for OtsAV.exe");
                        }
                        catch (Exception ex)
                        {
                        }

                    }

                }
                else
                {
                    // Do Nothing
                }

            }
            catch (Exception ex)
            {
            }

        }




        private void Button2_Click(object sender, EventArgs e)
        {
            
            
        }


        private void Button2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            NotifyIcon1.Visible = true;
            DateTime dt = DateTime.Today.AddHours(DateTime.Now.Hour);
            dt = dt.AddHours(1);
            double showtime = dt.Subtract(DateTime.Now).TotalMilliseconds;
            int timeInt = (int)showtime;
            opentimer.Interval = timeInt;
            opentimer.Enabled = true;
            NotifyIcon1.BalloonTipTitle = "NE1fm Console Minimised";
            NotifyIcon1.BalloonTipText = "Click the 'NE' icon next to clock to reopen the console, or it will open automatically at the start of the next hour.";
            NotifyIcon1.ShowBalloonTip(3000);
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void NotifyIcon1_Click(object sender, System.EventArgs e)
        {            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            NotifyIcon1.Visible = false;
            opentimer.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotifyIcon1.Click += new System.EventHandler(NotifyIcon1_Click);
            this.TopMost = true;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
            NotifyIcon1.Visible = true;
            
        }

        private void Form1_FormClosed(Object sender, FormClosedEventArgs e)
        {
            NotifyIcon1.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoteAccess ra = new RemoteAccess();
            ra.Show();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Stats();
        }

        private void logtime_Tick(object sender, EventArgs e)
        {
            LogProg();
        }

        private void songtimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("C:\\NE1fmConsole\\OfficePC.txt"))
                {
                    try
                    {
                        string npo = File.ReadAllText("\\\\NE1-LOGGER\\Logger\\LoggerNowPlaying\\nowplaying.txt");
                        if ((npo.Length > 25))
                        {
                            Label2.Text = (npo + "  :::  ");
                        }
                        else
                        {
                            Label2.Text = npo;
                        }

                    }
                    catch (Exception ex)
                    {
                        Label2.Text = "UNKNOWN";
                    }

                }
                else if (File.Exists("C:\\NE1fmConsole\\LoggerPC.txt"))
                {
                    string npo = File.ReadAllText("C:\\Logger\\LoggerNowPlaying\\nowplaying.txt");
                    if ((npo.Length > 25))
                    {
                        Label2.Text = (npo + "  :::  ");
                    }
                    else
                    {
                        Label2.Text = npo;
                    }

                }
                else
                {
                    Label2.Text = "Unconfigured Environment";
                }

            }
            catch (Exception ex)
            {
                Label2.Text = "UNKNOWN";
            }
        }

        private void songtimer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("C:\\NE1fmConsole\\OfficePC.txt"))
                {
                    try
                    {
                        DateTime npmod;
                        npmod = File.GetLastWriteTime("\\\\NE1-LOGGER\\Logger\\LoggerNowPlaying\\nowplaying.txt");
                        DateTime timenow;
                        timenow = DateTime.Now;
                        //int difftime;
                        //difftime = DateDiff(DateInterval.Minute, timenow, npmod);
                        if (npmod.AddSeconds(300) < timenow)
                        {
                            Label2.Text = "UNKNOWN";
                        }
                        else if ((Label2.Text.Length > 25))
                        {
                            Label2.Text = (Label2.Text.Substring((Label2.Text.Length - (Label2.Text.Length - 1))) + Label2.Text.Substring(0, 1));
                        }
                        else
                        {
                            // Label2.Text = My.Computer.FileSystem.ReadAllText("C:\LoggerNowPlaying\nowplaying.txt")
                        }

                    }
                    catch (Exception ex)
                    {
                        Label2.Text = "UNKNOWN";
                    }

                }
                else if (File.Exists("C:\\NE1fmConsole\\LoggerPC.txt"))
                {
                    DateTime npmod;
                    npmod = File.GetLastWriteTime("C:\\Logger\\LoggerNowPlaying\\nowplaying.txt");
                    DateTime timenow;
                    timenow = DateTime.Now;
                    //int difftime;
                    //difftime = DateDiff(DateInterval.Minute, timenow, npmod);
                    if (npmod.AddSeconds(300) < timenow)
                    {
                        Label2.Text = "UNKNOWN";
                    }
                    else if ((Label2.Text.Length > 25))
                    {
                        Label2.Text = (Label2.Text.Substring((Label2.Text.Length - (Label2.Text.Length - 1))) + Label2.Text.Substring(0, 1));
                    }
                    else
                    {
                        // Label2.Text = My.Computer.FileSystem.ReadAllText("C:\LoggerNowPlaying\nowplaying.txt")
                    }

                }
                else
                {
                    Label2.Text = "Unconfigured Environment";
                }

            }
            catch (Exception ex)
            {
                Label2.Text = "UNKNOWN";
            }

        }

        private void startstream_Tick(object sender, EventArgs e)
        {
            Stats();

            LogProg();

            startstream.Enabled = false;
        }

        private void contstream_Tick(object sender, EventArgs e)
        {
            Stats();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Interval = 600000;
            if (File.Exists("C:\\NE1fmConsole\\VBPC.txt"))
            {
                DialogResult result = MessageBox.Show("It appears you are using this program on a PC which is used for developmental purposes. Would you like to enable software update?", "Update?", MessageBoxButtons.YesNo);
                if ((result == DialogResult.No))
                {
                    Timer1.Enabled = false;
                    File.Delete("C:\\NE1fmConsole\\ConsoleUpdater.exe");
                }
                else if ((result == DialogResult.Yes))
                {
                    ConsoleUpdater();
                }
                else
                {
                    Timer1.Enabled = false;
                    File.Delete("C:\\NE1fmConsole\\ConsoleUpdater.exe");
                }

            }
            else
            {
                ConsoleUpdater();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            NotifyIcon1.Visible = false;
        }

        private void opentimer_Tick(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            NotifyIcon1.Visible = false;
            opentimer.Enabled = false;
        }

        private void cd_Tick(object sender, EventArgs e)
        {
            int time;
            time = Convert.ToInt32(Label9.Text);
            if ((time > 0))
            {
                int seconds = time;
                TimeSpan example1 = new TimeSpan(0, 0, seconds);
                DateTime example2 = DateTime.MinValue;
                example2 = example2.AddSeconds(seconds);
                int minone = time - 1;
                string timestring = Convert.ToString(minone);
                Label9.Text = (timestring);
                int corsec = (example2.Second - 1);
                string sec = corsec.ToString();
                sec = sec.PadLeft(2, '0');
                string min;
                if ((sec == "-1"))
                {
                    int cormin = (example2.Minute - 1);
                    min = cormin.ToString();
                    sec = "59";
                }
                else
                {
                    min = example2.Minute.ToString();
                }

                M1.Text = ("Refresh Data Now ("
                            + (min + (":"
                            + (sec + ")"))));
            }
        }

        private void Button1_Enter(object sender, EventArgs e)
        {
            PictureBox1.Select();
        }

        private void Button3_Enter(object sender, EventArgs e)
        {
            PictureBox1.Select();
        }

        private void Button2_Enter(object sender, EventArgs e)
        {
            PictureBox1.Select();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Changelog cl = new Changelog();
            cl.Show();
        }

        private void Label4_MouseEnter(object sender, EventArgs e)
        {
            if (this.Cursor != Cursors.WaitCursor)
            {
                this.Cursor = Cursors.Hand;
            }
        }

        private void Label4_MouseLeave(object sender, EventArgs e)
        {
            if (this.Cursor != Cursors.WaitCursor)
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", "/incognito 192.168.1.135");
        }

        private void button4_Enter(object sender, EventArgs e)
        {
            PictureBox1.Select();
        }



        private void M3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip OTSTOOL = new ToolTip();
            OTSTOOL.ShowAlways = true;
            OTSTOOL.IsBalloon = true;
            OTSTOOL.InitialDelay = 0;
            OTSTOOL.SetToolTip(M3, "Control OtsAV through the web.");
        }

        private void M1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void M5_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void M4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void officetest_Tick(object sender, EventArgs e)
        {
            string data = "System Online at " + DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss") + " on " + DateTime.Now.ToString("dd") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("yyyy") + "\n" ;
            File.AppendAllText("C:\\NE1fmConsole\\OnlineCheck.txt", data);
            officetest.Interval = 1800000;
        }

        private void M4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings fc = new Settings();
            fc.Show();
        }

        private void M4_Enter(object sender, EventArgs e)
        {
            PictureBox1.Select();
        }
    }
}
