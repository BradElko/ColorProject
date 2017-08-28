namespace ColorProject
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftColorPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.leftColorPanel);
            this.leftPanel.Location = new System.Drawing.Point(118, 100);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(210, 179);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leftPanel_MouseUp);
            // 
            // leftColorPanel
            // 
            this.leftColorPanel.BackColor = System.Drawing.Color.Black;
            this.leftColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftColorPanel.ForeColor = System.Drawing.Color.Black;
            this.leftColorPanel.Location = new System.Drawing.Point(9, 49);
            this.leftColorPanel.Name = "leftColorPanel";
            this.leftColorPanel.Size = new System.Drawing.Size(174, 81);
            this.leftColorPanel.TabIndex = 0;
            this.leftColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftColorPanel_Paint);
            this.leftColorPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leftColorPanel_MouseUp);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.rightLabel);
            this.rightPanel.Location = new System.Drawing.Point(458, 131);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(184, 130);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            this.rightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightPanel_MouseUp);
            // 
            // rightLabel
            // 
            this.rightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLabel.ForeColor = System.Drawing.Color.Black;
            this.rightLabel.Location = new System.Drawing.Point(12, 29);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(137, 70);
            this.rightLabel.TabIndex = 0;
            this.rightLabel.Text = "Black";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightLabel_Paint);
            this.rightLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightLabel_MouseUp);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.topLabel);
            this.topPanel.ForeColor = System.Drawing.Color.Transparent;
            this.topPanel.Location = new System.Drawing.Point(190, 46);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(361, 32);
            this.topPanel.TabIndex = 1;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.Color.White;
            this.topLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.Black;
            this.topLabel.Location = new System.Drawing.Point(40, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(261, 18);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "Click Here To Start";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topLabel_MouseDown);
            this.topLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topLabel_MouseUp);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftColorPanel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topLabel;
    }
}

