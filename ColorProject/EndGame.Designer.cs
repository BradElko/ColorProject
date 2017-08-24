namespace ColorProject
{
    partial class EndGame
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.topLabel = new System.Windows.Forms.Label();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.bottomLeftPanel = new System.Windows.Forms.Panel();
            this.bottomLeftLabel = new System.Windows.Forms.Label();
            this.bottomRightLabel = new System.Windows.Forms.Label();
            this.bottomRightPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.bottomLeftPanel.SuspendLayout();
            this.bottomRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topLabel);
            this.topPanel.Location = new System.Drawing.Point(207, 30);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(197, 136);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(61, 62);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(100, 23);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "You Won!";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // middlePanel
            // 
            this.middlePanel.Location = new System.Drawing.Point(131, 191);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(427, 205);
            this.middlePanel.TabIndex = 1;
            this.middlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.middlePanel_Paint);
            // 
            // bottomLeftPanel
            // 
            this.bottomLeftPanel.Controls.Add(this.bottomLeftLabel);
            this.bottomLeftPanel.Location = new System.Drawing.Point(100, 432);
            this.bottomLeftPanel.Name = "bottomLeftPanel";
            this.bottomLeftPanel.Size = new System.Drawing.Size(431, 154);
            this.bottomLeftPanel.TabIndex = 2;
            this.bottomLeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomLeftPanel_Paint);
            // 
            // bottomLeftLabel
            // 
            this.bottomLeftLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeftLabel.Location = new System.Drawing.Point(82, 35);
            this.bottomLeftLabel.Name = "bottomLeftLabel";
            this.bottomLeftLabel.Size = new System.Drawing.Size(193, 76);
            this.bottomLeftLabel.TabIndex = 0;
            this.bottomLeftLabel.Text = "Play Again?";
            this.bottomLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomLeftLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottomLeftLabel_MouseDown);
            this.bottomLeftLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bottomLeftLabel_MouseUp);
            // 
            // bottomRightLabel
            // 
            this.bottomRightLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRightLabel.Location = new System.Drawing.Point(41, 55);
            this.bottomRightLabel.Name = "bottomRightLabel";
            this.bottomRightLabel.Size = new System.Drawing.Size(144, 68);
            this.bottomRightLabel.TabIndex = 1;
            this.bottomRightLabel.Text = "Exit";
            this.bottomRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomRightLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottomRightLabel_MouseDown);
            this.bottomRightLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bottomRightLabel_MouseUp);
            // 
            // bottomRightPanel
            // 
            this.bottomRightPanel.Controls.Add(this.bottomRightLabel);
            this.bottomRightPanel.Location = new System.Drawing.Point(484, 14);
            this.bottomRightPanel.Name = "bottomRightPanel";
            this.bottomRightPanel.Size = new System.Drawing.Size(233, 152);
            this.bottomRightPanel.TabIndex = 3;
            this.bottomRightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomRightPanel_Paint);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 598);
            this.Controls.Add(this.bottomRightPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.bottomLeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndGame";
            this.Text = " ";
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.topPanel.ResumeLayout(false);
            this.bottomLeftPanel.ResumeLayout(false);
            this.bottomRightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel bottomLeftPanel;
        private System.Windows.Forms.Label bottomRightLabel;
        private System.Windows.Forms.Label bottomLeftLabel;
        private System.Windows.Forms.Panel bottomRightPanel;
    }
}