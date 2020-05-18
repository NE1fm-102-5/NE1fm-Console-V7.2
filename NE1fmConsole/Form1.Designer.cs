namespace NE1fmConsole6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.M1 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.M5 = new System.Windows.Forms.Button();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.starttime = new System.Windows.Forms.Timer(this.components);
            this.logtime = new System.Windows.Forms.Timer(this.components);
            this.songtimer = new System.Windows.Forms.Timer(this.components);
            this.songtimer2 = new System.Windows.Forms.Timer(this.components);
            this.startstream = new System.Windows.Forms.Timer(this.components);
            this.contstream = new System.Windows.Forms.Timer(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.opentimer = new System.Windows.Forms.Timer(this.components);
            this.cd = new System.Windows.Forms.Timer(this.components);
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Label9 = new System.Windows.Forms.Label();
            this.M3 = new System.Windows.Forms.Button();
            this.M4 = new System.Windows.Forms.Button();
            this.RAT = new System.Windows.Forms.Label();
            this.officetest = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // M1
            // 
            this.M1.Enabled = false;
            this.M1.Location = new System.Drawing.Point(406, 41);
            this.M1.Margin = new System.Windows.Forms.Padding(4);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(195, 38);
            this.M1.TabIndex = 28;
            this.M1.Text = "Refreshing Data...";
            this.M1.UseVisualStyleBackColor = true;
            this.M1.Click += new System.EventHandler(this.Button1_Click);
            this.M1.Enter += new System.EventHandler(this.Button1_Enter);
            this.M1.MouseEnter += new System.EventHandler(this.M1_MouseEnter);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Label8.Location = new System.Drawing.Point(7, 199);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(525, 15);
            this.Label8.TabIndex = 26;
            this.Label8.Text = "NOTE: Logger may report as Not Recording or In Minutes for up to an hour after be" +
    "ing restarted.";
            this.Label8.Visible = false;
            // 
            // M5
            // 
            this.M5.Location = new System.Drawing.Point(506, 133);
            this.M5.Margin = new System.Windows.Forms.Padding(4);
            this.M5.Name = "M5";
            this.M5.Size = new System.Drawing.Size(95, 46);
            this.M5.TabIndex = 25;
            this.M5.Text = "Minimise Software";
            this.M5.UseVisualStyleBackColor = true;
            this.M5.Click += new System.EventHandler(this.Button2_Click);
            this.M5.Enter += new System.EventHandler(this.Button2_Enter);
            this.M5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseDown);
            this.M5.MouseEnter += new System.EventHandler(this.M5_MouseEnter);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(139, 174);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(155, 17);
            this.Label27.TabIndex = 24;
            this.Label27.Text = "Collecting Information...";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(15, 173);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(115, 17);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "Logger Status:";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(139, 144);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(155, 17);
            this.Label22.TabIndex = 22;
            this.Label22.Text = "Collecting Information...";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(13, 144);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(115, 17);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Stream Status:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label4.Location = new System.Drawing.Point(269, 55);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(90, 17);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "What\'s New?";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            this.Label4.MouseEnter += new System.EventHandler(this.Label4_MouseEnter);
            this.Label4.MouseLeave += new System.EventHandler(this.Label4_MouseLeave);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(238, 31);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(156, 17);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "NE1fm Console V7.2";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(8, 13);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(226, 87);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 18;
            this.PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoEllipsis = true;
            this.Label2.Location = new System.Drawing.Point(139, 113);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(229, 16);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Collecting Information...";
            this.Label2.UseMnemonic = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 113);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 17);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Current Song: ";
            // 
            // starttime
            // 
            this.starttime.Enabled = true;
            this.starttime.Interval = 3000;
            // 
            // logtime
            // 
            this.logtime.Enabled = true;
            this.logtime.Interval = 60000;
            this.logtime.Tick += new System.EventHandler(this.logtime_Tick);
            // 
            // songtimer
            // 
            this.songtimer.Enabled = true;
            this.songtimer.Interval = 20000;
            this.songtimer.Tick += new System.EventHandler(this.songtimer_Tick);
            // 
            // songtimer2
            // 
            this.songtimer2.Enabled = true;
            this.songtimer2.Interval = 300;
            this.songtimer2.Tick += new System.EventHandler(this.songtimer2_Tick);
            // 
            // startstream
            // 
            this.startstream.Enabled = true;
            this.startstream.Interval = 15000;
            this.startstream.Tick += new System.EventHandler(this.startstream_Tick);
            // 
            // contstream
            // 
            this.contstream.Interval = 302000;
            this.contstream.Tick += new System.EventHandler(this.contstream_Tick);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 10000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // opentimer
            // 
            this.opentimer.Tick += new System.EventHandler(this.opentimer_Tick);
            // 
            // cd
            // 
            this.cd.Interval = 1000;
            this.cd.Tick += new System.EventHandler(this.cd_Tick);
            // 
            // ToolTip1
            // 
            this.ToolTip1.ShowAlways = true;
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "NE1fm Console";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Enabled = false;
            this.Label9.Location = new System.Drawing.Point(357, 256);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(32, 17);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "301";
            this.Label9.Visible = false;
            // 
            // M3
            // 
            this.M3.Location = new System.Drawing.Point(406, 87);
            this.M3.Margin = new System.Windows.Forms.Padding(4);
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(194, 35);
            this.M3.TabIndex = 31;
            this.M3.Text = "OtsAV Web Control";
            this.M3.UseVisualStyleBackColor = true;
            this.M3.Click += new System.EventHandler(this.button4_Click);
            this.M3.Enter += new System.EventHandler(this.button4_Enter);
            this.M3.MouseEnter += new System.EventHandler(this.M3_MouseEnter);
            // 
            // M4
            // 
            this.M4.Location = new System.Drawing.Point(406, 133);
            this.M4.Margin = new System.Windows.Forms.Padding(4);
            this.M4.Name = "M4";
            this.M4.Size = new System.Drawing.Size(95, 46);
            this.M4.TabIndex = 32;
            this.M4.Text = "Update and Settings";
            this.M4.UseVisualStyleBackColor = true;
            this.M4.Click += new System.EventHandler(this.M4_Click);
            this.M4.Enter += new System.EventHandler(this.M4_Enter);
            this.M4.MouseEnter += new System.EventHandler(this.M4_MouseEnter);
            // 
            // RAT
            // 
            this.RAT.AutoSize = true;
            this.RAT.Enabled = false;
            this.RAT.Location = new System.Drawing.Point(429, 302);
            this.RAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RAT.Name = "RAT";
            this.RAT.Size = new System.Drawing.Size(24, 17);
            this.RAT.TabIndex = 37;
            this.RAT.Text = "20";
            this.RAT.Visible = false;
            // 
            // officetest
            // 
            this.officetest.Enabled = true;
            this.officetest.Interval = 10000;
            this.officetest.Tick += new System.EventHandler(this.officetest_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Copyright 2019 © Harry Smith";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 226);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.M4);
            this.Controls.Add(this.M3);
            this.Controls.Add(this.M5);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.RAT);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label27);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NE1fm Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button M1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button M5;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Timer starttime;
        internal System.Windows.Forms.Timer logtime;
        internal System.Windows.Forms.Timer songtimer;
        internal System.Windows.Forms.Timer songtimer2;
        internal System.Windows.Forms.Timer startstream;
        internal System.Windows.Forms.Timer contstream;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Timer opentimer;
        internal System.Windows.Forms.Timer cd;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.NotifyIcon NotifyIcon1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button M3;
        internal System.Windows.Forms.Button M4;
        internal System.Windows.Forms.Label RAT;
        private System.Windows.Forms.Timer officetest;
        internal System.Windows.Forms.Label label7;
    }
}

