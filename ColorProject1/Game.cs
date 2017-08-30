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
        public static int randomColor, accurateClicks, inaccurateClicks, seconds;
        string colorOutput, colorOutput1, colorOutput2, selectedColor1, selectedColor2;
        public static System.Diagnostics.Stopwatch clickingTimer = new System.Diagnostics.Stopwatch();
        public Game()
        {
            //Adds colors to the list and chooses a color from that list.
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
            //If you left-clicked (Mouse Down) the Top Panel instead of the Top Label...
            if(e.Button == MouseButtons.Left)
            {
                //Adds an inaccurate click.
                inaccurateClicks++;
            }
        }
        private void topLabel_MouseDown(object sender, MouseEventArgs e)
        {
            /* If the Left Color Panel Color == Selected Color...
             * If the Right Color Text == Seleceed Color Text...
             * If the Right Color Text Color == Selected Color...
             * If you left-clicked (Mouse Down) the Top Label...
            */
            if (clickedRightColor && clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                //Top Label Color = Initial Color.
                topLabel.ForeColor = Color.FromName(colorOutput);
            }
        }
        private void topLabel_MouseUp(object sender, MouseEventArgs e)
        {
            /* If the Left Color Panel != Selected Color...
             * If the Right Color Text != Selected Color Text...
             * If the Right Color Text Color != Selected Color...
             * If the Top Label Text == "Click Here To Start"...
             * If you left-clicked (Mouse Up) the Top Label...
            */
            if (!clickedRightColor && !clickedRightName && !clickedRightNameColor && topLabel.Text == "Click Here To Start" && e.Button == MouseButtons.Left)
            {
                /* Top Label Text = Initial  Color Text.
                 * Sets the accurate and inaccurate clicks to 0.
                 * Starts the Timer and confirms that the Timer has started.
                */
                topLabel.Text = colorOutput;
                accurateClicks = 0;
                inaccurateClicks = 0;
                clickingTimer.Start();
            }
            /* If the Left Color Panel Color == Selected Color...
             * If the Right Color Text = Selected Color Text...
             * If the Right Color Text Color = Selected Color...
             * If you left-clicked (Mouse Up) the Top Label...
            */
            else if (clickedRightColor && clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                /* Adds an accurate click.
                 * Clears the clipboard.
                 * Stops the Timer.
                 * Adds the seconds to an Integer.
                 * Resets the Timer.
                 * Top Label Color = Black.
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
            /* If Left Color Panel Color != Initial Color...
             * If Top Label Text != "Click Here To Start"...
             * If you left-clicked (Mouse Up) the Left Color Panel...
            */
            if (!clickedRightColor && topLabel.Text != "Click Here To Start" && e.Button == MouseButtons.Left)
            {
                //while the Selected Color = Previous Selected Color...
                while (selectedColor1 == colorOutput1)
                {
                    //Picks a color from the list.
                    randomColor = r.Next(colors.Count);
                    colorOutput1 = colors[randomColor];
                }
                //If the Selected Color != Initial Color...
                if (colorOutput1 != colorOutput)
                {
                    /* Label Color Panel Color = Selected Color.
                     * Confirms Selected Color.
                     * Adds an accurate click.
                    */
                    leftColorPanel.BackColor = Color.FromName(colorOutput1);
                    selectedColor1 = colorOutput1;
                    accurateClicks++;
                }
                //If the Selected Color == Initial Color...
                else if (colorOutput1 == colorOutput)
                {
                    /* Left Color Panel Color = Initial Color.
                     * Changes the Cursor.
                     * Adds an accurate click.
                     * Confirms Correct Color.
                    */
                    leftColorPanel.BackColor = Color.FromName(colorOutput1);
                    leftColorPanel.Cursor = Cursors.Default;
                    accurateClicks++;
                    clickedRightColor = true;
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
            /* If the Right Label Text != Initial Color Text...
             * If the Top Label Text != "Click Here To Start"...
             * If you left-clicked (Mouse Up) the Right Label...
            */
            if(!clickedRightName && topLabel.Text != "Click Here To Start" && e.Button == MouseButtons.Left)
            {
                //while the Selected Color = Previous Selected Color...
                while (selectedColor2 == colorOutput2)
                {
                    //Picks a color from the list.
                    randomColor = r.Next(colors.Count);
                    colorOutput2 = colors[randomColor];
                }
                //If the Selected Color != Initial Color...
                if (colorOutput2 != colorOutput)
                {
                    /* Right Label Text = Selected Color Text.
                     * Confirms Selected Color.
                     * Adds an accurate click.
                    */
                    rightLabel.Text = colorOutput2;
                    selectedColor2 = colorOutput2;
                    accurateClicks++;
                }
                //If the Selected Color == Initial Color...
                else if (colorOutput2 == colorOutput)
                {
                    /* Right Label Text = Initial Color Text.
                     * Confirms Selected Color 
                     * Adds an accurate click.
                     * Confirms Correct Color.
                    */
                    rightLabel.Text = colorOutput2;
                    selectedColor2 = colorOutput2;
                    accurateClicks++;
                    clickedRightName = true;
                }
            }
            /* If the Right Label Text == Initial Color Text...
             * If the Right Label Text Color != Initial Color Text Color...
             * If you left-clicked (Mouse Up) the Right Label...
            */
            else if (clickedRightName && !clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                //while the Selected Color = Previous Selected Color...
                while (selectedColor2 == colorOutput2)
                {
                    //Picks a color from the list.
                    randomColor = r.Next(colors.Count);
                    colorOutput2 = colors[randomColor];
                }
                //If the Selected Color != Initial Color...
                if (colorOutput2 != colorOutput)
                {
                    /* Right Label Text Color = Selected Color.
                     * Confirms Selected Color.
                     * Adds an accurate click.
                    */
                    rightLabel.ForeColor = Color.FromName(colorOutput2);
                    selectedColor2 = colorOutput2;
                    accurateClicks++;
                }
                //If the Selected Color == Initial Color...
                else if (colorOutput2 == colorOutput)
                {
                    /* Right Label Text Color = Initial Color.
                     * Adds an accurate click.
                     * Changes the Cursor
                     * Confirms Correct Color.
                     * Clears the clipboard.
                    */
                    rightLabel.ForeColor = Color.FromName(colorOutput2);
                    accurateClicks++;
                    rightLabel.Cursor = Cursors.Default;
                    clickedRightNameColor = true;
                    System.Windows.Forms.Clipboard.Clear();
                }
            }
            /* If the Right Label Text == Initial Color Text...
             * If the Right Label Text Color == Initial Color Text Color...
             * If you left-clicked (Mouse Up) the Right Label...
            */
            else if (clickedRightName && clickedRightNameColor && e.Button == MouseButtons.Left)
            {
                //Adds an inaccurate click.
                inaccurateClicks++;
            }
        }
    }
}
