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
    public partial class Form1 : Form
    {
        private List<string> colors = new List<string>();
        Pen pens = new Pen(Color.White, 1);
        public Form1()
        {
            colors.Add("Red");
            colors.Add("Orange");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Purple");           
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = this.ClientRectangle;
            Pen p = new Pen(Color.White);
            r.Height -= 1;
            r.Width -= 1;
            e.Graphics.DrawRectangle(p, r);
        }
        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.White);
            e.Graphics.DrawLine(p, 0, 98, 799, 98);
        }
        private void topLabel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = topLabel.ClientRectangle;
            Pen p = new Pen(Color.White);
            r.Height -= 1;
            r.Width -= 1;
            e.Graphics.DrawRectangle(p, r);
        }
        private void leftColorPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = leftColorPanel.ClientRectangle;
            Pen p = new Pen(Color.White);
            r.Height -= 1;
            r.Width -= 1;
            e.Graphics.DrawRectangle(p, r);
        }
        private void rightLabel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = rightLabel.ClientRectangle;
            Pen p = new Pen(Color.White);
            r.Height -= 1;
            r.Width -= 1;
            e.Graphics.DrawRectangle(p, r);
        }
    }
}
