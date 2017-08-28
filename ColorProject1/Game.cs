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
        bool clockStarted, clickedRightColor, clickedRightName, clickedRightNameColor;
        List<string> colors = new List<string>();
        Random r = new Random();
        public static int randomColor, accurateClicks, inaccurateClicks;
        string colorOutput;
        public static System.Diagnostics.Stopwatch clickingTimer = new System.Diagnostics.Stopwatch();
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
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Form
            this.Location = new Point(0, 0);
            this.Width = Screen.GetWorkingArea(this).Width;
            this.Height= Screen.GetWorkingArea(this).Height;
            //Top1
            topPanel.Height = 100;
            topPanel.Width = Screen.GetWorkingArea(this).Width;
            topPanel.Location = new Point(0, 0);
            //Top2
            topLabel.Height = topPanel.Height - 3;
            topLabel.Width = topPanel.Width - 4;
            topLabel.Location = new Point(2, 2);
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
            rightLabel.Height = 80;
            rightLabel.Width = Convert.ToInt32(rightPanel.Width * .8);
            rightLabel.Location = new Point(Convert.ToInt32(rightPanel.Width * .1),
                (rightPanel.Height / 2) - 40);
            this.Update();
        }
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            inaccurateClicks++;
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
        private void topLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (clickedRightColor && clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                topLabel.ForeColor = Color.FromName(colorOutput);
            }
        }
        private void topLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if(!clockStarted && !clickedRightColor && !clickedRightName && !clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                topLabel.Text = colorOutput;
                accurateClicks = 0;
                inaccurateClicks = 0;
                clickingTimer.Start();
                clockStarted = true;
            }
            else if (clickedRightColor && clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                accurateClicks++;
                clickingTimer.Stop();
                Console.WriteLine("Score: " + (clickingTimer.Elapsed.Seconds + inaccurateClicks + accurateClicks) +
                    "\nTime: " + clickingTimer.Elapsed.Seconds + 
                    "\nBad Clicks: " + inaccurateClicks + 
                    "\nGood Clicks: " + accurateClicks);
                EndGame egform = new EndGame();
                egform.Show();
                this.Hide();
                topLabel.ForeColor = Color.Black;
            }
            else
            {
                inaccurateClicks++;
            }
        }
        private void leftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            inaccurateClicks++;
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
            if (!clickedRightColor && topLabel.Text != "Click Here To Start" && e.Button == MouseButtons.Left)
            {
                randomColor = r.Next(colors.Count);
                string colorOutput2 = colors[randomColor];
                while (colorOutput2 == leftColorPanel.BackColor.Name)
                {
                    randomColor = r.Next(colors.Count);
                    colorOutput2 = colors[randomColor];
                    if (colorOutput2 != leftColorPanel.BackColor.Name)
                    {
                        leftColorPanel.BackColor = Color.FromName(colorOutput2);
                        accurateClicks++;
                        break;
                    }
                }
                if (colorOutput2 != leftColorPanel.BackColor.Name)
                {
                    leftColorPanel.BackColor = Color.FromName(colorOutput2);
                    accurateClicks++;
                }
                if (Convert.ToString(leftColorPanel.BackColor.Name) == colorOutput)
                {
                    clickedRightColor = true;
                    leftColorPanel.Cursor = Cursors.Default;
                }
            }
            else if (clickedRightColor && e.Button == MouseButtons.Left)
            {
                inaccurateClicks++;
            }
        }
        private void rightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            inaccurateClicks++;
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
            if(!clickedRightName && topLabel.Text != "Click Here To Start" && e.Button == MouseButtons.Left)
            {
                randomColor = r.Next(colors.Count);
                string colorOutput2 = colors[randomColor];
                while (colorOutput2 == rightLabel.Text)
                {
                    randomColor = r.Next(colors.Count);
                    colorOutput2 = colors[randomColor];
                    if (colorOutput2 != rightLabel.Text)
                    {
                        rightLabel.Text = colorOutput2;
                        accurateClicks++;
                        break;
                    }
                }
                if (colorOutput2 != rightLabel.Text)
                {
                    rightLabel.Text = colorOutput2;
                    accurateClicks++;
                }
                if (rightLabel.Text == colorOutput)
                {
                    clickedRightName = true;
                }
            }
            else if(clickedRightName && !clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                randomColor = r.Next(colors.Count);
                string colorOutput2 = colors[randomColor];
                while (rightLabel.ForeColor == Color.FromName(colorOutput2))
                {
                    randomColor = r.Next(colors.Count);
                    colorOutput2 = colors[randomColor];
                    if (rightLabel.ForeColor != Color.FromName(colorOutput2))
                    {
                        rightLabel.ForeColor = Color.FromName(colorOutput2);
                        accurateClicks++;
                        break;
                    }
                }
                if (rightLabel.ForeColor != Color.FromName(colorOutput2))
                {
                    rightLabel.ForeColor = Color.FromName(colorOutput2);
                    accurateClicks++;
                }
                if (rightLabel.ForeColor.Name == colorOutput)
                {
                    clickedRightNameColor = true;
                    rightLabel.Cursor = Cursors.Default;
                }
            }
            else if (clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                inaccurateClicks++;
            }
        }
    }
}
