namespace NE1fmConsole6
{
    partial class RemoteAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteAccess));
            this.RAT = new System.Windows.Forms.Label();
            this.RAC = new System.Windows.Forms.Button();
            this.RA3 = new System.Windows.Forms.Button();
            this.RA2 = new System.Windows.Forms.Button();
            this.RA1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.RACLOSE = new System.Windows.Forms.Timer(this.components);
            this.RACOUNT = new System.Windows.Forms.Timer(this.components);
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RAT
            // 
            this.RAT.AutoSize = true;
            this.RAT.Enabled = false;
            this.RAT.Location = new System.Drawing.Point(493, 150);
            this.RAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RAT.Name = "RAT";
            this.RAT.Size = new System.Drawing.Size(24, 17);
            this.RAT.TabIndex = 13;
            this.RAT.Text = "20";
            this.RAT.Visible = false;
            // 
            // RAC
            // 
            this.RAC.Location = new System.Drawing.Point(297, 170);
            this.RAC.Margin = new System.Windows.Forms.Padding(4);
            this.RAC.Name = "RAC";
            this.RAC.Size = new System.Drawing.Size(284, 48);
            this.RAC.TabIndex = 11;
            this.RAC.Text = "Back (20)";
            this.RAC.UseVisualStyleBackColor = true;
            this.RAC.Click += new System.EventHandler(this.Button4_Click);
            // 
            // RA3
            // 
            this.RA3.Location = new System.Drawing.Point(297, 105);
            this.RA3.Margin = new System.Windows.Forms.Padding(4);
            this.RA3.Name = "RA3";
            this.RA3.Size = new System.Drawing.Size(284, 37);
            this.RA3.TabIndex = 10;
            this.RA3.TabStop = false;
            this.RA3.Text = "Connect to Office PC";
            this.RA3.UseVisualStyleBackColor = true;
            this.RA3.Click += new System.EventHandler(this.Button3_Click);
            this.RA3.Enter += new System.EventHandler(this.Button3_Enter);
            // 
            // RA2
            // 
            this.RA2.Location = new System.Drawing.Point(297, 60);
            this.RA2.Margin = new System.Windows.Forms.Padding(4);
            this.RA2.Name = "RA2";
            this.RA2.Size = new System.Drawing.Size(284, 37);
            this.RA2.TabIndex = 9;
            this.RA2.TabStop = false;
            this.RA2.Text = "Connect to Logger PC";
            this.RA2.UseVisualStyleBackColor = true;
            this.RA2.Click += new System.EventHandler(this.Button2_Click);
            this.RA2.Enter += new System.EventHandler(this.Button2_Enter);
            // 
            // RA1
            // 
            this.RA1.Location = new System.Drawing.Point(297, 16);
            this.RA1.Margin = new System.Windows.Forms.Padding(4);
            this.RA1.Name = "RA1";
            this.RA1.Size = new System.Drawing.Size(284, 37);
            this.RA1.TabIndex = 8;
            this.RA1.TabStop = false;
            this.RA1.Text = "Connect to OtsAV PC";
            this.RA1.UseVisualStyleBackColor = true;
            this.RA1.Click += new System.EventHandler(this.Button1_Click);
            this.RA1.Enter += new System.EventHandler(this.Button1_Enter);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 98);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(249, 119);
            this.Label1.TabIndex = 7;
            this.Label1.Text = resources.GetString("Label1.Text");
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RACLOSE
            // 
            this.RACLOSE.Enabled = true;
            this.RACLOSE.Interval = 22000;
            this.RACLOSE.Tick += new System.EventHandler(this.closetimer_Tick);
            // 
            // RACOUNT
            // 
            this.RACOUNT.Enabled = true;
            this.RACOUNT.Interval = 1000;
            this.RACOUNT.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // ToolTip1
            // 
            this.ToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(45, 10);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(211, 82);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 12;
            this.PictureBox1.TabStop = false;
            // 
            // RemoteAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 226);
            this.Controls.Add(this.RAT);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.RAC);
            this.Controls.Add(this.RA3);
            this.Controls.Add(this.RA2);
            this.Controls.Add(this.RA1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoteAccess";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RemoteAccess";
            this.Load += new System.EventHandler(this.RemoteAccess_Load);
            this.Shown += new System.EventHandler(this.RemoteAccess_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label RAT;
        internal System.Windows.Forms.Button RAC;
        internal System.Windows.Forms.Button RA3;
        internal System.Windows.Forms.Button RA2;
        internal System.Windows.Forms.Button RA1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Timer RACLOSE;
        internal System.Windows.Forms.Timer RACOUNT;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}