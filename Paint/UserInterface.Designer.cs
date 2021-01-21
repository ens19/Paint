namespace Paint
{
    partial class UserInterface
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
            this.uxPaintPanel = new System.Windows.Forms.Panel();
            this.uxColorBox = new System.Windows.Forms.Panel();
            this.uxRed = new System.Windows.Forms.PictureBox();
            this.uxBlue = new System.Windows.Forms.PictureBox();
            this.uxBlack = new System.Windows.Forms.PictureBox();
            this.uxYellow = new System.Windows.Forms.PictureBox();
            this.uxPaintPanel.SuspendLayout();
            this.uxColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPaintPanel
            // 
            this.uxPaintPanel.Controls.Add(this.uxColorBox);
            this.uxPaintPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.uxPaintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPaintPanel.Location = new System.Drawing.Point(0, 0);
            this.uxPaintPanel.Name = "uxPaintPanel";
            this.uxPaintPanel.Size = new System.Drawing.Size(1556, 923);
            this.uxPaintPanel.TabIndex = 0;
            this.uxPaintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxPaintPanel_MouseDown);
            this.uxPaintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uxPaintPanel_MouseMove);
            this.uxPaintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uxPaintPanel_MouseUp);
            // 
            // uxColorBox
            // 
            this.uxColorBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uxColorBox.Controls.Add(this.uxYellow);
            this.uxColorBox.Controls.Add(this.uxBlack);
            this.uxColorBox.Controls.Add(this.uxBlue);
            this.uxColorBox.Controls.Add(this.uxRed);
            this.uxColorBox.Location = new System.Drawing.Point(1143, 12);
            this.uxColorBox.Name = "uxColorBox";
            this.uxColorBox.Size = new System.Drawing.Size(401, 113);
            this.uxColorBox.TabIndex = 0;
            // 
            // uxRed
            // 
            this.uxRed.BackColor = System.Drawing.Color.Red;
            this.uxRed.Location = new System.Drawing.Point(20, 18);
            this.uxRed.Name = "uxRed";
            this.uxRed.Size = new System.Drawing.Size(73, 77);
            this.uxRed.TabIndex = 0;
            this.uxRed.TabStop = false;
            this.uxRed.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // uxBlue
            // 
            this.uxBlue.BackColor = System.Drawing.Color.Blue;
            this.uxBlue.Location = new System.Drawing.Point(112, 18);
            this.uxBlue.Name = "uxBlue";
            this.uxBlue.Size = new System.Drawing.Size(73, 77);
            this.uxBlue.TabIndex = 1;
            this.uxBlue.TabStop = false;
            this.uxBlue.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // uxBlack
            // 
            this.uxBlack.BackColor = System.Drawing.Color.Black;
            this.uxBlack.Location = new System.Drawing.Point(303, 18);
            this.uxBlack.Name = "uxBlack";
            this.uxBlack.Size = new System.Drawing.Size(75, 77);
            this.uxBlack.TabIndex = 3;
            this.uxBlack.TabStop = false;
            this.uxBlack.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // uxYellow
            // 
            this.uxYellow.BackColor = System.Drawing.Color.Yellow;
            this.uxYellow.Location = new System.Drawing.Point(204, 18);
            this.uxYellow.Name = "uxYellow";
            this.uxYellow.Size = new System.Drawing.Size(73, 77);
            this.uxYellow.TabIndex = 4;
            this.uxYellow.TabStop = false;
            this.uxYellow.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 923);
            this.Controls.Add(this.uxPaintPanel);
            this.Name = "UserInterface";
            this.Text = "Paint Application";
            this.uxPaintPanel.ResumeLayout(false);
            this.uxColorBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxYellow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uxPaintPanel;
        private System.Windows.Forms.Panel uxColorBox;
        private System.Windows.Forms.PictureBox uxYellow;
        private System.Windows.Forms.PictureBox uxBlack;
        private System.Windows.Forms.PictureBox uxBlue;
        private System.Windows.Forms.PictureBox uxRed;
    }
}

