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
            topLabel.Height = Convert.ToInt32(topPanel.Height * .8);
            topLabel.Width = Convert.ToInt32(topPanel.Width * .9);
            topLabel.Location = new Point(Convert.ToInt32(topPanel.Width * .05),
                Convert.ToInt32(topPanel.Height * .1));
            //Left1
            leftPanel.Height = Screen.GetWorkingArea(this).Height - 200;
            leftPanel.Width = Screen.GetWorkingArea(this).Width / 2;
            leftPanel.Location = new Point(0, 100);
            //Right1
            rightPanel.Height = Screen.GetWorkingArea(this).Height - 200;
            rightPanel.Width = Screen.GetWorkingArea(this).Width / 2;
            rightPanel.Location = new Point(Screen.GetWorkingArea(this).Width / 2, 100);
            //Bottom1
            bottomPanel.Height = 100;
            bottomPanel.Width = Screen.GetWorkingArea(this).Width;
            bottomPanel.Location = new Point(0, Screen.GetWorkingArea(this).Height - 100);
            //Bottom2
            bottomLabel.Height = Convert.ToInt32(bottomPanel.Height * .8);
            bottomLabel.Width = Convert.ToInt32(bottomPanel.Width * .9);
            bottomLabel.Location = new Point(Convert.ToInt32(bottomPanel.Width * .05),
                Convert.ToInt32(bottomPanel.Height * .1));
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
            randomColor = r.Next(colors.Count);
            colorOutput = colors[randomColor];
            bottomLabel.ForeColor = Color.FromName(colorOutput);
        }
        private void bottomLabel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Hide();
            Game gform = new Game();
            gform.Show();
        }
    }
}
