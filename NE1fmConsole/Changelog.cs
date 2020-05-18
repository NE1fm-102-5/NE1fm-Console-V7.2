using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NE1fmConsole6
{
    public partial class Changelog : Form
    {
        public Changelog()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page1.Visible)
            {
                page1.Visible = false;
                page2.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else if (page2.Visible)
            {
                page2.Visible = false;
                page3.Visible = true;
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page3.Visible)
            {
                page3.Visible = false;
                page2.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else if (page2.Visible)
            {
                page2.Visible = false;
                page1.Visible = true;
                button1.Enabled = false;
                button2.Enabled = true;
            }
            
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            button3.Select();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button3.Select();
        }

        private void Changelog_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
