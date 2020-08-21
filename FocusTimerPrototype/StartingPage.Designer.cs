namespace FocusTimerPrototype
{
    partial class StartingPage
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.WelcomeStartButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(10, 10);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(315, 50);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Focus Timer";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeStartButton
            // 
            this.WelcomeStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeStartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WelcomeStartButton.Location = new System.Drawing.Point(9, 172);
            this.WelcomeStartButton.Margin = new System.Windows.Forms.Padding(0);
            this.WelcomeStartButton.Name = "WelcomeStartButton";
            this.WelcomeStartButton.Size = new System.Drawing.Size(315, 30);
            this.WelcomeStartButton.TabIndex = 1;
            this.WelcomeStartButton.Text = "Start";
            this.WelcomeStartButton.UseVisualStyleBackColor = true;
            this.WelcomeStartButton.Click += new System.EventHandler(this.WelcomeStartButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.DescriptionLabel.Location = new System.Drawing.Point(10, 70);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(315, 100);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "This application is designed to help you focus on getting tasks done.\r\nRemember:\r" +
    "\nThis depends on YOU to put in the work to keep you focused.";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.WelcomeStartButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StartingPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Focus Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button WelcomeStartButton;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}

