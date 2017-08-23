using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ColorProject
{
    public partial class Game : Form
    {
        bool clickedRightColor, clickedRightName, clickedRightNameColor;
        List<string> colors = new List<string>();
        Random r = new Random();
        int randomColor, amountOfClicks;
        string colorOutput;
        System.Diagnostics.Stopwatch clickingTimer = new System.Diagnostics.Stopwatch();
        public Game()
        {
            colors.Add("Red");
            colors.Add("Orange");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Purple");
            randomColor = r.Next(colors.Count);
            colorOutput = colors[randomColor];
            amountOfClicks = 0;
            InitializeComponent();
            topLabel.Text = colorOutput;
            clickingTimer.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Form
            this.Location = new Point(0, 0);
            this.Width = Screen.GetWorkingArea(this).Width;
            this.Height= Screen.GetWorkingArea(this).Height;
            this.Update();
            //Top1
            topPanel.Height = 100;
            topPanel.Width = Screen.GetWorkingArea(this).Width;
            topPanel.Location = new Point(0, 0);
            //Top2
            topLabel.Height = Convert.ToInt32(topPanel.Height * .8);
            topLabel.Width = Convert.ToInt32(topPanel.Width * .9);
            topLabel.Location = new Point(Convert.ToInt32(topPanel.Width * .05),
                Convert.ToInt32(topPanel.Height * .1));
            //Left1
            leftPanel.Height = Screen.GetWorkingArea(this).Height - 100;
            leftPanel.Width = Screen.GetWorkingArea(this).Width / 2;
            leftPanel.Location = new Point(0, 100);
            //Left2
            leftColorPanel.Height = Convert.ToInt32(leftPanel.Height *.8);
            leftColorPanel.Width = Convert.ToInt32(leftPanel.Width * .8);
            leftColorPanel.Location = new Point(Convert.ToInt32(leftPanel.Width * .1),
            Convert.ToInt32(leftPanel.Height * .1));
            //Right1
            rightPanel.Height = Screen.GetWorkingArea(this).Height - 100;
            rightPanel.Width = Screen.GetWorkingArea(this).Width / 2;
            rightPanel.Location = new Point(Screen.GetWorkingArea(this).Width / 2, 100);
            //Right2
            rightLabel.Height = Convert.ToInt32(rightPanel.Height * .15);
            rightLabel.Width = Convert.ToInt32(rightPanel.Width * .8);
            rightLabel.Location = new Point(Convert.ToInt32(rightPanel.Width * .1),
            Convert.ToInt32(rightPanel.Height * .425));
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
        private void topLabel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, topLabel.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
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
                Color.Black, 2,
                ButtonBorderStyle.Solid);
        }
        private void leftColorPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, leftColorPanel.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void leftColorPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (!clickedRightColor)
            {
                randomColor = r.Next(colors.Count);
                string colorOutput2 = colors[randomColor];
                leftColorPanel.BackColor = Color.FromName(colorOutput2);
                amountOfClicks++;
                if (Convert.ToString(leftColorPanel.BackColor.Name) == colorOutput)
                {
                    clickedRightColor = true;
                }
            }
            else if (clickedRightColor && clickedRightName && clickedRightNameColor)
            {
                clickingTimer.Stop();
                Console.WriteLine(clickingTimer.Elapsed.Minutes);
            }
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
                Color.Black, 2,
                ButtonBorderStyle.Solid);
        }
        private void rightLabel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, rightLabel.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void rightLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if(!clickedRightName)
            {
                randomColor = r.Next(colors.Count);
                string colorOutput2 = colors[randomColor];
                rightLabel.Text = colorOutput2;
                amountOfClicks++;
                if (rightLabel.Text == colorOutput)
                {
                    clickedRightName = true;
                }
            }
            else if(clickedRightName && !clickedRightNameColor)
            {
                randomColor = r.Next(colors.Count);
                string colorOutput2 = colors[randomColor];
                rightLabel.ForeColor = Color.FromName(colorOutput2);
                amountOfClicks++;
                if (rightLabel.ForeColor.Name == colorOutput)
                {
                    clickedRightNameColor = true;
                }
            }
            else if (clickedRightColor && clickedRightName && clickedRightNameColor)
            {
                clickingTimer.Stop();
                Console.WriteLine(clickingTimer.Elapsed.Minutes);
            }
        }
    }
}
