namespace ColorProject
{
    partial class BeginGame
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topLabel);
            this.topPanel.Location = new System.Drawing.Point(98, 54);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(426, 150);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(121, 48);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(227, 59);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Color Clicker";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            this.leftPanel.Location = new System.Drawing.Point(81, 246);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(287, 133);
            this.leftPanel.TabIndex = 1;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(483, 246);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(256, 133);
            this.rightPanel.TabIndex = 2;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.bottomLabel);
            this.bottomPanel.Location = new System.Drawing.Point(186, 395);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(299, 100);
            this.bottomPanel.TabIndex = 3;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomPanel_Paint);
            // 
            // bottomLabel
            // 
            this.bottomLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabel.Location = new System.Drawing.Point(36, 21);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(227, 59);
            this.bottomLabel.TabIndex = 1;
            this.bottomLabel.Text = "Play";
            this.bottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottomLabel_MouseDown);
            this.bottomLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bottomLabel_MouseUp);
            // 
            // BeginGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 507);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BeginGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BeginGame_Load);
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label bottomLabel;
    }
}