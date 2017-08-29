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
        public static int randomColor, accurateClicks, inaccurateClicks, seconds;
        string colorOutput;
        public static System.Diagnostics.Stopwatch clickingTimer = new System.Diagnostics.Stopwatch();
        public Game()
        {
            /* Adds colors to the list. 
             * Chooses a color.
            */
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
            //Top Panel
            topPanel.Height = 100;
            topPanel.Width = Screen.GetWorkingArea(this).Width;
            topPanel.Location = new Point(0, 0);
            //Top Label
            topLabel.Height = topPanel.Height - 3;
            topLabel.Width = topPanel.Width - 4;
            topLabel.Location = new Point(2, 2);
            //Left Panel
            leftPanel.Height = Screen.GetWorkingArea(this).Height - 100;
            leftPanel.Width = Screen.GetWorkingArea(this).Width / 2;
            leftPanel.Location = new Point(0, 100);
            //Left Color Panel
            leftColorPanel.Height = Convert.ToInt32(leftPanel.Height *.8);
            leftColorPanel.Width = Convert.ToInt32(leftPanel.Width * .8);
            leftColorPanel.Location = new Point(Convert.ToInt32(leftPanel.Width * .1),
                Convert.ToInt32(leftPanel.Height * .1));
            //Right Panel
            rightPanel.Height = Screen.GetWorkingArea(this).Height - 100;
            rightPanel.Width = Screen.GetWorkingArea(this).Width / 2;
            rightPanel.Location = new Point(Screen.GetWorkingArea(this).Width / 2, 100);
            //Right Label
            rightLabel.Height = 80;
            rightLabel.Width = Convert.ToInt32(rightPanel.Width * .8);
            rightLabel.Location = new Point(Convert.ToInt32(rightPanel.Width * .1),
                (rightPanel.Height / 2) - 40);
            //Form Update
            this.Update();
        }
        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            //Top Panel Black Border.
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
            //Left Panel Black Border.
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
        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {
            //Right Panel Black Border.
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
        private void leftColorPanel_Paint(object sender, PaintEventArgs e)
        {
            //Left Color Panel Black Border.
            ControlPaint.DrawBorder(e.Graphics, leftColorPanel.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void rightLabel_Paint(object sender, PaintEventArgs e)
        {
            //Right Label Black Border.
            ControlPaint.DrawBorder(e.Graphics, rightLabel.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //If you left-click (Mouse Down) the Top Panel instead of the Top Label
            if(e.Button == MouseButtons.Left)
            {
                //Adds an inaccurate click.
                inaccurateClicks++;
            }
        }
        private void topLabel_MouseDown(object sender, MouseEventArgs e)
        {
            /* If the Left Color Panel = Selected Color...
             * If the Right Color Name = Seleceed Color Name...
             * If the Right Color Name Color = Selected Color...
             * If you left-clicked (Mouse Down) the Top Label...
            */
            if (clickedRightColor && clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                //Turns the Top Label to the selected color.
                topLabel.ForeColor = Color.FromName(colorOutput);
            }
        }
        private void topLabel_MouseUp(object sender, MouseEventArgs e)
        {
            /* If the Clock did not start...
             * If the Left Color Panel != Selected Color...
             * If the Right Color Name != Selected Color...
             * If the Right Color Name Color != Selected Color...
             * If you left-clicked (Mouse Up) the Top Label...
            */
            if (!clockStarted && !clickedRightColor && !clickedRightName && !clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                /* Puts the Top Label text to the Selected Color Name.
                 * Sets the accurate and inaccurate clicks to 0.
                 * Starts the timer and confirms that the timer started.
                */
                topLabel.Text = colorOutput;
                accurateClicks = 0;
                inaccurateClicks = 0;
                clickingTimer.Start();
                clockStarted = true;
            }
            /* If the Left Color Panel = Selected Color...
             * If the Right Color Name = Selected Color...
             * If the Right Color Name Color = Selected Color...
             * If you left-clicked (Mouse Up) the Top Label...
            */
            else if (clickedRightColor && clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                /* Adds an accurate click.
                 * Clears the clipboard.
                 * Stops the timer.
                 * Adds the seconds to an Integer.
                 * Resets the timer.
                 * Changes the text color to black.
                 * Closes this form and opens the EndGame form.
                */
                accurateClicks++;
                System.Windows.Forms.Clipboard.Clear();
                clickingTimer.Stop();
                seconds = clickingTimer.Elapsed.Seconds;
                clickingTimer.Reset();
                topLabel.ForeColor = Color.Black;
                EndGame egform = new EndGame();
                egform.Show();
                this.Hide();
            }
            else
            {
                //Adds an inaccurate click.
                inaccurateClicks++;
            }
        }
        private void leftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //If you left-clicked (Mouse Down) the Left Panel instead of the Left Color Panel...
            if (e.Button == MouseButtons.Left)
            {
                //Adds an inaccurate click.
                inaccurateClicks++;
            }
        }
        private void leftColorPanel_MouseUp(object sender, MouseEventArgs e)
        {
            /* If Left Color Panel Color != Selected Color...
             * If Top Label Text is not the default text...
             * If you left-clicked (Mouse Up) the Left Color Panel...
            */
            if (!clickedRightColor && topLabel.Text != "Click Here To Start" && e.Button == MouseButtons.Left)
            {
                //Picks a color from the list.
                randomColor = r.Next(colors.Count);
                string colorOutput2 = colors[randomColor];
                //while the Selected Color is equal to the previous Selected Color...
                while (colorOutput2 == leftColorPanel.BackColor.Name)
                {
                    //Picks another color from the list.
                    randomColor = r.Next(colors.Count);
                    colorOutput2 = colors[randomColor];
                    //If the Selected Color is not equal to the Initial Color...
                    if (colorOutput2 != leftColorPanel.BackColor.Name)
                    {
                        /* Changes the Left Color Panel to the Selected Color.
                         * Adds an accurate click.
                         * Breaks out of the while loop.
                        */
                        leftColorPanel.BackColor = Color.FromName(colorOutput2);
                        accurateClicks++;
                        break;
                    }
                }
                //If the Left Color Panel Color is not equal to the Initial Color...
                if (colorOutput2 != leftColorPanel.BackColor.Name)
                {
                    /* The Left Color Panel Color is equal to the Selected Color.
                     * Adds an accurate click.
                    */
                    leftColorPanel.BackColor = Color.FromName(colorOutput2);
                    accurateClicks++;
                }
                //If the Left Color Panel Color is equal to the Initial Color...
                if (Convert.ToString(leftColorPanel.BackColor.Name) == colorOutput)
                {
                    /* Confirms the Left Color Panel Color is equal to the Initial Color.
                     * Sets the Cursor back to the default Cursor.
                    */
                    clickedRightColor = true;
                    leftColorPanel.Cursor = Cursors.Default;
                }
            }
            /* If Left Color Panel Color = Selected Color...
             * If you left-clicked (Mouse Up) the Left Color Panel...
            */
            else if (clickedRightColor && e.Button == MouseButtons.Left)
            {
                //Adds an inaccurate click.
                inaccurateClicks++;
            }
        }
        private void rightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //If you left-clicked (Mouse Up) the Right Panel instead of the Right Label...
            if (e.Button == MouseButtons.Left)
            {
                //Adds an inaccurate click.
                inaccurateClicks++;
            }
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
                System.Windows.Forms.Clipboard.Clear();
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
                System.Windows.Forms.Clipboard.Clear();
            }
            else if (clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                inaccurateClicks++;
            }
        }
    }
}
