using System;
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
    public partial class EndGame : Form
    {
        List<string> colors = new List<string>();
        Random r = new Random();
        int randomColor;
        string colorOutput;
        public EndGame()
        {
            colors.Add("Red");
            colors.Add("Orange");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Purple");
            InitializeComponent();
        }
        private void EndGame_Load(object sender, EventArgs e)
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
            topLabel.Height = Convert.ToInt32(topPanel.Height * .8);
            topLabel.Width = Convert.ToInt32(topPanel.Width * .9);
            topLabel.Location = new Point(Convert.ToInt32(topPanel.Width * .05),
                Convert.ToInt32(topPanel.Height * .1));
            //Middle1
            middlePanel.Height = Screen.GetWorkingArea(this).Height - 200;
            middlePanel.Width = Screen.GetWorkingArea(this).Width;
            middlePanel.Location = new Point(0, 100);
            //BottomLeft1
            bottomLeftPanel.Height = 100;
            bottomLeftPanel.Width = Screen.GetWorkingArea(this).Width/2;
            bottomLeftPanel.Location = new Point(0, Screen.GetWorkingArea(this).Height - 100);
            //BottomLeft2
            bottomLeftLabel.Height = Convert.ToInt32(bottomLeftPanel.Height * .8);
            bottomLeftLabel.Width = Convert.ToInt32(bottomLeftPanel.Width * .9);
            bottomLeftLabel.Location = new Point(Convert.ToInt32(bottomLeftPanel.Width * .05),
                Convert.ToInt32(bottomLeftPanel.Height * .1));
            //BottomRight1
            bottomRightPanel.Height = 100;
            bottomRightPanel.Width = Screen.GetWorkingArea(this).Width/2;
            bottomRightPanel.Location = new Point(Screen.GetWorkingArea(this).Width / 2, 
                Screen.GetWorkingArea(this).Height - 100);
            //BottomRight2
            bottomRightLabel.Height = Convert.ToInt32(bottomRightPanel.Height * .8);
            bottomRightLabel.Width = Convert.ToInt32(bottomRightPanel.Width * .9);
            bottomRightLabel.Location = new Point(Convert.ToInt32(bottomRightPanel.Width * .05),
                Convert.ToInt32(bottomRightPanel.Height * .1));
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
        private void middlePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                middlePanel.ClientRectangle,
                Color.Black, 2,
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
                bottomLeftPanel.ClientRectangle,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid);
        }
        private void bottomLeftPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                bottomLeftPanel.ClientRectangle,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid);
        }
        private void bottomLeftLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                randomColor = r.Next(colors.Count);
                colorOutput = colors[randomColor];
                bottomLeftLabel.ForeColor = Color.FromName(colorOutput);
            }
        }
        private void bottomLeftLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Game gform = new ColorProject.Game();
                gform.Show();
                this.Hide();
            }
        }
        private void bottomRightPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                bottomRightPanel.ClientRectangle,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 1,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid,
                Color.Black, 2,
                ButtonBorderStyle.Solid);
        }
        private void bottomRightLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                randomColor = r.Next(colors.Count);
                colorOutput = colors[randomColor];
                bottomRightLabel.ForeColor = Color.FromName(colorOutput);
            }
        }
        private void bottomRightLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
