namespace NE1fmConsole6
{
    partial class Changelog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelog));
            this.page1 = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.page3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // page1
            // 
            this.page1.AutoSize = true;
            this.page1.Location = new System.Drawing.Point(19, 23);
            this.page1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(374, 493);
            this.page1.TabIndex = 0;
            this.page1.Text = resources.GetString("page1.Text");
            // 
            // page2
            // 
            this.page2.AutoSize = true;
            this.page2.Location = new System.Drawing.Point(22, 23);
            this.page2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(383, 459);
            this.page2.TabIndex = 1;
            this.page2.Text = resources.GetString("page2.Text");
            this.page2.Visible = false;
            this.page2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(22, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Newer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 449);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Older";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enter += new System.EventHandler(this.button2_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 449);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // page3
            // 
            this.page3.AutoSize = true;
            this.page3.Location = new System.Drawing.Point(22, 23);
            this.page3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(405, 204);
            this.page3.TabIndex = 5;
            this.page3.Text = resources.GetString("page3.Text");
            this.page3.Visible = false;
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 510);
            this.Controls.Add(this.page3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.page2);
            this.Controls.Add(this.page1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Changelog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Console Changelog";
            this.Load += new System.EventHandler(this.Changelog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label page1;
        private System.Windows.Forms.Label page2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label page3;
    }
}