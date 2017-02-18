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
using System.Diagnostics;

namespace ProgramAccessTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuStrip MainMenu = new MenuStrip();
            this.Size = new Size(230, 295);

            //group one shortcuts
            shortcut1grp1btn.Enabled = false;
            shortcut2grp1btn.Enabled = false;
            shortcut3grp1btn.Enabled = false;
            shortcut4grp1btn.Enabled = false;
            shortcut5grp1btn.Enabled = false;
            OpenAllgrp1btn.Enabled = false;

            //shortcuts group 2
            shortcut1grp2btn.Enabled = false;
            shortcut2grp2btn.Enabled = false;
            shortcut3grp2btn.Enabled = false;
            shortcut4grp2btn.Enabled = false;
            shortcut5grp2btn.Enabled = false;
            OpenAllgrp2btn.Enabled = false;

            //shortcuts group 3
            shortcut1grp3btn.Enabled = false;
            shortcut2grp3btn.Enabled = false;
            shortcut3grp3btn.Enabled = false;
            shortcut4grp3btn.Enabled = false;
            shortcut5grp3btn.Enabled = false;
            OpenAllgrp3btn.Enabled = false;
            
            //tab control menu
            tabControl2.Enabled = false;
            tabControl2.Visible = false;
            tabControl3.Enabled = false;
            tabControl3.Visible = false;
            groupTwoToolStripMenuItem.Visible = false;
            groupThreeToolStripMenuItem.Visible = false;
            groupOneToolStripMenuItem.Enabled = false;
            groupTwoToolStripMenuItem.Enabled = false;
            groupThreeToolStripMenuItem.Enabled = false;
            removeGroupToolStripMenuItem.Enabled = false;
            hideGroupToolStripMenuItem.Enabled = false;
            removeGroupToolStripMenuItem.Visible = false;
        }

        //exit menu strip
        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Seriously?","Oh?", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //add group menu strip
        void addGroupToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (tabControl2.Enabled == false)
            {
                tabControl2.Enabled = true;
                tabControl2.Visible = true;
                this.Size = new Size(435, 295);
                groupTwoToolStripMenuItem.Visible = true;
                removeGroupToolStripMenuItem.Enabled = true;
                hideGroupToolStripMenuItem.Enabled = true;
            }
            else
            {
                tabControl3.Enabled = true;
                tabControl3.Visible = true;
                addGroupToolStripMenuItem.Enabled = false;
                this.Size = new Size(640, 295);
                groupThreeToolStripMenuItem.Visible = true;
                hideGroupToolStripMenuItem.Enabled = true;
            }
        }

        //hide group menu control
        private void hideGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl3.Enabled == true)
            {
                tabControl3.Enabled = false;
                tabControl3.Visible = false;
                this.Size = new Size(435, 295);
                addGroupToolStripMenuItem.Enabled = true;
                groupThreeToolStripMenuItem.Visible = false;
            }
            else
            {
                tabControl2.Enabled = false;
                tabControl2.Visible = false;
                this.Size = new Size(230, 295);
                addGroupToolStripMenuItem.Enabled = true;
                groupTwoToolStripMenuItem.Visible = false;
                removeGroupToolStripMenuItem.Enabled = false;
                hideGroupToolStripMenuItem.Enabled = false;
            }
        }

        //still working on this. want to add a Clear();
        void removeGroupToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (tabControl3.Enabled == true)
            {
                tabControl3.Enabled = false;
                tabControl3.Visible = false;
                this.Size = new Size(435, 295);
                addGroupToolStripMenuItem.Enabled = true;
                groupThreeToolStripMenuItem.Visible = false;
                button14.BackColor = Color.LightGray;
                filename1grp3 = "";
            }
            else
            {
                tabControl2.Enabled = false;
                tabControl2.Visible = false;
                this.Size = new Size(230, 295);
                addGroupToolStripMenuItem.Enabled = true;
                groupTwoToolStripMenuItem.Visible = false;
                removeGroupToolStripMenuItem.Enabled = false;
            }
        }

        //global file name variables
        string filename = "";
        string filename2 = "";
        string filename3 = "";
        string filename4 = "";
        string filename5 = "";
        string filename1grp2 = "";
        string filename2grp2 = "";
        string filename3grp2 = "";
        string filename4grp2 = "";
        string filename5grp2 = "";
        string filename1grp3 = "";
        string filename2grp3 = "";
        string filename3grp3 = "";
        string filename4grp3 = "";
        string filename5grp3 = "";

        //shortcut 1 group 1
        private void button1_Click(object sender, EventArgs e)
        { Process.Start(filename);}

        //shortcut 2 group 1
        private void button4_Click(object sender, EventArgs e)
        { Process.Start(filename2); }

        //shortcut 3 group 1
        private void button16_Click(object sender, EventArgs e)
        { Process.Start(filename3); }

        //shortcut 4 group 1
        private void button17_Click(object sender, EventArgs e)
        { Process.Start(filename4); }

        //shortcut 5 group 1
        private void button18_Click(object sender, EventArgs e)
        { Process.Start(filename5); }

        //set shortcut 1 group 1
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename);
                shortcut1grp1btn.Text = filenamewithoutpath;
                shortcut1grp1btn.Enabled = true;
                OpenAllgrp1btn.Enabled = true;
                button2.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 2 group 1
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename2 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename2);
                shortcut2grp1btn.Text = filenamewithoutpath;
                shortcut2grp1btn.Enabled = true;
                OpenAllgrp1btn.Enabled = true;
                button3.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 3 group 1
        private void button19_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename3 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename3);
                shortcut3grp1btn.Text = filenamewithoutpath;
                shortcut3grp1btn.Enabled = true;
                OpenAllgrp1btn.Enabled = true;
                button19.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 4 group 1
        private void button20_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename4 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename4);
                shortcut4grp1btn.Text = filenamewithoutpath;
                shortcut4grp1btn.Enabled = true;
                OpenAllgrp1btn.Enabled = true;
                button20.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 5 group 1
        private void button21_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename5 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename5);
                shortcut5grp1btn.Text = filenamewithoutpath;
                shortcut5grp1btn.Enabled = true;
                OpenAllgrp1btn.Enabled = true;
                button21.BackColor = Color.LawnGreen;
            }
        }
        
        //group 1 open all
        private void button5_Click(object sender, EventArgs e)
        {
            if (filename == "")
            { }
            else
            { Process.Start(filename); }
            if (filename2 == "")
            { }
            else
            { Process.Start(filename2); }
            if (filename3 == "")
            { }
            else
            { Process.Start(filename3); }
            if (filename4 == "")
            { }
            else
            { Process.Start(filename4); }
            if (filename5 == "")
            { }
            else
            { Process.Start(filename5); }
        }

        //shortcut 1 group 2
        private void button6_Click(object sender, EventArgs e)
        { Process.Start(filename1grp2); }

        //shortcut 2 group 2
        private void button7_Click(object sender, EventArgs e)
        { Process.Start(filename2grp2); }

        //shortcut 3 group 2
        private void button22_Click(object sender, EventArgs e)
        { Process.Start(filename3grp2); }

        //shortcut 4 group 2
        private void button23_Click(object sender, EventArgs e)
        { Process.Start(filename4grp2); }

        //shortcut 5 group 2
        private void button24_Click(object sender, EventArgs e)
        { Process.Start(filename5grp2); }

        //set shortcut 1 group 2
        private void button12_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename1grp2 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename1grp2);
                shortcut1grp2btn.Text = filenamewithoutpath;
                shortcut1grp2btn.Enabled = true;
                OpenAllgrp2btn.Enabled = true;
                button12.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 2 group 2
        private void button13_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename2grp2 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename2grp2);
                shortcut2grp2btn.Text = filenamewithoutpath;
                shortcut2grp2btn.Enabled = true;
                OpenAllgrp2btn.Enabled = true;
                button13.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 3 group 2
        private void button25_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename3grp2 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename3grp2);
                shortcut3grp2btn.Text = filenamewithoutpath;
                shortcut3grp2btn.Enabled = true;
                OpenAllgrp2btn.Enabled = true;
                button25.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 4 group 2
        private void button26_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename4grp2 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename4grp2);
                shortcut4grp2btn.Text = filenamewithoutpath;
                shortcut4grp2btn.Enabled = true;
                OpenAllgrp2btn.Enabled = true;
                button26.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 5 group 2
        private void button27_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename5grp2 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename5grp2);
                shortcut5grp2btn.Text = filenamewithoutpath;
                shortcut5grp2btn.Enabled = true;
                OpenAllgrp2btn.Enabled = true;
                button27.BackColor = Color.LawnGreen;
            }
        }

        //group 2 open all
        private void button8_Click(object sender, EventArgs e)
        {
            if (filename1grp2 == "")
            { }
            else
            { Process.Start(filename1grp2); }
            if (filename2grp2 == "")
            { }
            else
            { Process.Start(filename2grp2); }
            if (filename3grp2 == "")
            { }
            else
            { Process.Start(filename3grp2); }
            if (filename4grp2 == "")
            { }
            else
            { Process.Start(filename4grp2); }
            if (filename5grp2 == "")
            { }
            else
            { Process.Start(filename5grp2); }
        }

        //shortcut 1 group 3
        private void button9_Click(object sender, EventArgs e)
        { Process.Start(filename1grp3); }

        //shortcut 2 group 3
        private void button10_Click(object sender, EventArgs e)
        { Process.Start(filename2grp3);}

        //shortcut 3 group 3
        private void button28_Click(object sender, EventArgs e)
        { Process.Start(filename3grp3); }

        //shortcut 4 group 3
        private void button29_Click(object sender, EventArgs e)
        { Process.Start(filename4grp3); }

        //shortcut 5 group 3
        private void button30_Click(object sender, EventArgs e)
        { Process.Start(filename5grp3); }

        //set shortcut 1 group 3
        private void button14_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename1grp3 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename1grp3);
                shortcut1grp3btn.Text = filenamewithoutpath;
                shortcut1grp3btn.Enabled = true;
                OpenAllgrp3btn.Enabled = true;
                button14.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 2 group 3
        private void button15_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename2grp3 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename2grp3);
                shortcut2grp3btn.Text = filenamewithoutpath;
                shortcut2grp3btn.Enabled = true;
                OpenAllgrp3btn.Enabled = true;
                button15.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 3 group 3
        private void button31_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename3grp3 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename3grp3);
                shortcut3grp3btn.Text = filenamewithoutpath;
                shortcut3grp3btn.Enabled = true;
                OpenAllgrp3btn.Enabled = true;
                button31.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 4 group 4
        private void button32_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename4grp3 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename4grp3);
                shortcut4grp3btn.Text = filenamewithoutpath;
                shortcut4grp3btn.Enabled = true;
                OpenAllgrp3btn.Enabled = true;
                button32.BackColor = Color.LawnGreen;
            }
        }

        //set shortcut 5 group 5
        private void button33_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename5grp3 = openFileDialog1.FileName;
                string filenamewithoutpath = Path.GetFileName(filename5grp3);
                shortcut5grp3btn.Text = filenamewithoutpath;
                shortcut5grp3btn.Enabled = true;
                OpenAllgrp3btn.Enabled = true;
                button33.BackColor = Color.LawnGreen;
            }
        }

        //group three open all
        private void button11_Click(object sender, EventArgs e)
        {
            if (filename1grp3 == "")
            { }
            else
            { Process.Start(filename1grp3); }
            if (filename2grp3 == "")
            { }
            else
            { Process.Start(filename2grp3); }
            if (filename3grp3 == "")
            { }
            else
            { Process.Start(filename3grp3); }
            if (filename4grp3 == "")
            { }
            else
            { Process.Start(filename4grp3); }
            if (filename5grp3 == "")
            { }
            else
            { Process.Start(filename5grp3); }
        }

    }
}
