﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorProject
{
    public partial class BeginGame : Form
    {
        List<string> colors = new List<string>();
        Random r = new Random();
        int randomColor;
        string colorOutput;
        public BeginGame()
        {
            colors.Add("Red");
            colors.Add("Orange");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Purple");
            InitializeComponent();
        }
        private void BeginGame_Load(object sender, EventArgs e)
        {
            //Form
            this.Location = new Point(0, 0);
            this.Width = Screen.GetWorkingArea(this).Width;
            this.Height = Screen.GetWorkingArea(this).Height;
            //Top1
            topPanel.Height = 100;
            topPanel.Width = Screen.GetWorkingArea(this).Width;
            topPanel.Location = new Point(0, 0);
            //Top2
            topLabel.Height = topPanel.Height - 3;
            topLabel.Width = topPanel.Width - 4;
            topLabel.Location = new Point(2, 2);
            //Left1
            leftPanel.Height = Screen.GetWorkingArea(this).Height - 200;
            leftPanel.Width = Screen.GetWorkingArea(this).Width / 2;
            leftPanel.Location = new Point(0, 100);
            //Left2
            leftLabel.Height = leftPanel.Height / 5;
            leftLabel.Width = leftPanel.Width - 4;
            leftLabel.Location = new Point(2, 1);
            rightTextbox.Height = Convert.ToInt16(leftPanel.Height * .6);
            rightTextbox.Width = Convert.ToInt16(leftPanel.Width * .8);
            rightTextbox.Location = new Point(Convert.ToInt16(leftPanel.Width * .1),
                Convert.ToInt16(leftPanel.Height * .2) + 1);
            //Right1
            rightPanel.Height = Screen.GetWorkingArea(this).Height - 200;
            rightPanel.Width = Screen.GetWorkingArea(this).Width / 2;
            rightPanel.Location = new Point(Screen.GetWorkingArea(this).Width / 2, 100);
            //Right2
            rightLabel.Height = rightPanel.Height / 5;
            rightLabel.Width = rightPanel.Width - 4;
            rightLabel.Location = new Point(2, 1);
            leftTextbox.Height = Convert.ToInt16(rightPanel.Height * .6);
            leftTextbox.Width = Convert.ToInt16(rightPanel.Width * .8);
            leftTextbox.Location = new Point(Convert.ToInt16(rightPanel.Width * .1),
                Convert.ToInt16(rightPanel.Height * .2) + 1);
            //Bottom1
            bottomPanel.Height = 100;
            bottomPanel.Width = Screen.GetWorkingArea(this).Width;
            bottomPanel.Location = new Point(0, Screen.GetWorkingArea(this).Height - 100);
            //Bottom2
            bottomLabel.Height = bottomPanel.Height - 3;
            bottomLabel.Width = bottomPanel.Width - 4;
            bottomLabel.Location = new Point(2, 2);
            this.Update();
        }
        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                topPanel.ClientRectangle,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid);
        }
        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                leftPanel.ClientRectangle,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid);
        }
        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                rightPanel.ClientRectangle,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid);
        }
        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                bottomPanel.ClientRectangle,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid);
        }
        private void bottomLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                randomColor = r.Next(colors.Count);
                colorOutput = colors[randomColor];
                bottomLabel.ForeColor = Color.FromName(colorOutput);
            }
        }
        private void bottomLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Game gform = new Game();
                gform.Show();
                this.Hide();
            }
        }
    }
}
