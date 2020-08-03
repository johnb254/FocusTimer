namespace FocusTimerPrototype
{
    partial class BreakPage
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
            this.components = new System.ComponentModel.Container();
            this.PreFocusTitleLabel = new System.Windows.Forms.Label();
            this.FocusInstructionLabel = new System.Windows.Forms.Label();
            this.setupButton = new System.Windows.Forms.Button();
            this.BreakTimerLabel = new System.Windows.Forms.Label();
            this.BreakTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PreFocusTitleLabel
            // 
            this.PreFocusTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreFocusTitleLabel.Font = new System.Drawing.Font("Noto Sans Cond", 18F);
            this.PreFocusTitleLabel.Location = new System.Drawing.Point(110, 9);
            this.PreFocusTitleLabel.Name = "PreFocusTitleLabel";
            this.PreFocusTitleLabel.Size = new System.Drawing.Size(120, 30);
            this.PreFocusTitleLabel.TabIndex = 1;
            this.PreFocusTitleLabel.Text = "Break Time";
            this.PreFocusTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FocusInstructionLabel
            // 
            this.FocusInstructionLabel.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.FocusInstructionLabel.Location = new System.Drawing.Point(10, 50);
            this.FocusInstructionLabel.Name = "FocusInstructionLabel";
            this.FocusInstructionLabel.Size = new System.Drawing.Size(315, 75);
            this.FocusInstructionLabel.TabIndex = 2;
            this.FocusInstructionLabel.Text = "The taskbar is available again\r\nUse this downtime to rest your brain\r\nPerhaps ste" +
    "p away from the computer to rest your eyes as well\r\n\r\nFocus time resumes in:";
            this.FocusInstructionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // setupButton
            // 
            this.setupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setupButton.ForeColor = System.Drawing.Color.Black;
            this.setupButton.Location = new System.Drawing.Point(12, 169);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(310, 30);
            this.setupButton.TabIndex = 4;
            this.setupButton.Text = "Back to Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // BreakTimerLabel
            // 
            this.BreakTimerLabel.AutoSize = true;
            this.BreakTimerLabel.Location = new System.Drawing.Point(146, 134);
            this.BreakTimerLabel.Name = "BreakTimerLabel";
            this.BreakTimerLabel.Size = new System.Drawing.Size(46, 22);
            this.BreakTimerLabel.TabIndex = 5;
            this.BreakTimerLabel.Text = "00:00";
            this.BreakTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BreakTimer
            // 
            this.BreakTimer.Interval = 1000;
            this.BreakTimer.Tick += new System.EventHandler(this.BreakTimer_Tick);
            // 
            // BreakPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.BreakTimerLabel);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.FocusInstructionLabel);
            this.Controls.Add(this.PreFocusTitleLabel);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BreakPage";
            this.Text = "PreBreakPage";
            this.Load += new System.EventHandler(this.BreakPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PreFocusTitleLabel;
        private System.Windows.Forms.Label FocusInstructionLabel;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Label BreakTimerLabel;
        private System.Windows.Forms.Timer BreakTimer;
    }
}