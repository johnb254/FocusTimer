namespace FocusTimerPrototype
{
    partial class SetupPage
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
            this.SetupTitleLabel = new System.Windows.Forms.Label();
            this.FocusPromptLabel = new System.Windows.Forms.Label();
            this.FocusPromptTextBox = new System.Windows.Forms.TextBox();
            this.BreakPromptLabel = new System.Windows.Forms.Label();
            this.BreakPromptTextBox = new System.Windows.Forms.TextBox();
            this.SetupStartButton = new System.Windows.Forms.Button();
            this.FocusMinutesLabel = new System.Windows.Forms.Label();
            this.BreakMinutesLabel = new System.Windows.Forms.Label();
            this.SetupCloseButton = new System.Windows.Forms.Button();
            this.TaskbarCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SetupTitleLabel
            // 
            this.SetupTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupTitleLabel.ForeColor = System.Drawing.Color.White;
            this.SetupTitleLabel.Location = new System.Drawing.Point(10, 10);
            this.SetupTitleLabel.Name = "SetupTitleLabel";
            this.SetupTitleLabel.Size = new System.Drawing.Size(315, 20);
            this.SetupTitleLabel.TabIndex = 0;
            this.SetupTitleLabel.Text = "Setup";
            this.SetupTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FocusPromptLabel
            // 
            this.FocusPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusPromptLabel.ForeColor = System.Drawing.Color.White;
            this.FocusPromptLabel.Location = new System.Drawing.Point(10, 30);
            this.FocusPromptLabel.Name = "FocusPromptLabel";
            this.FocusPromptLabel.Size = new System.Drawing.Size(85, 20);
            this.FocusPromptLabel.TabIndex = 1;
            this.FocusPromptLabel.Text = "Focus Time:";
            this.FocusPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FocusPromptTextBox
            // 
            this.FocusPromptTextBox.Location = new System.Drawing.Point(14, 53);
            this.FocusPromptTextBox.Name = "FocusPromptTextBox";
            this.FocusPromptTextBox.Size = new System.Drawing.Size(81, 29);
            this.FocusPromptTextBox.TabIndex = 2;
            // 
            // BreakPromptLabel
            // 
            this.BreakPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BreakPromptLabel.ForeColor = System.Drawing.Color.White;
            this.BreakPromptLabel.Location = new System.Drawing.Point(12, 101);
            this.BreakPromptLabel.Name = "BreakPromptLabel";
            this.BreakPromptLabel.Size = new System.Drawing.Size(85, 20);
            this.BreakPromptLabel.TabIndex = 3;
            this.BreakPromptLabel.Text = "Break Time:";
            this.BreakPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BreakPromptTextBox
            // 
            this.BreakPromptTextBox.Location = new System.Drawing.Point(14, 124);
            this.BreakPromptTextBox.Name = "BreakPromptTextBox";
            this.BreakPromptTextBox.Size = new System.Drawing.Size(81, 29);
            this.BreakPromptTextBox.TabIndex = 4;
            // 
            // SetupStartButton
            // 
            this.SetupStartButton.Location = new System.Drawing.Point(10, 175);
            this.SetupStartButton.Name = "SetupStartButton";
            this.SetupStartButton.Size = new System.Drawing.Size(155, 30);
            this.SetupStartButton.TabIndex = 5;
            this.SetupStartButton.Text = "Start";
            this.SetupStartButton.UseVisualStyleBackColor = true;
            this.SetupStartButton.Click += new System.EventHandler(this.SetupStartButton_Click);
            // 
            // FocusMinutesLabel
            // 
            this.FocusMinutesLabel.AutoSize = true;
            this.FocusMinutesLabel.ForeColor = System.Drawing.Color.White;
            this.FocusMinutesLabel.Location = new System.Drawing.Point(101, 56);
            this.FocusMinutesLabel.Name = "FocusMinutesLabel";
            this.FocusMinutesLabel.Size = new System.Drawing.Size(60, 22);
            this.FocusMinutesLabel.TabIndex = 6;
            this.FocusMinutesLabel.Text = "minutes";
            // 
            // BreakMinutesLabel
            // 
            this.BreakMinutesLabel.AutoSize = true;
            this.BreakMinutesLabel.ForeColor = System.Drawing.Color.White;
            this.BreakMinutesLabel.Location = new System.Drawing.Point(101, 127);
            this.BreakMinutesLabel.Name = "BreakMinutesLabel";
            this.BreakMinutesLabel.Size = new System.Drawing.Size(60, 22);
            this.BreakMinutesLabel.TabIndex = 7;
            this.BreakMinutesLabel.Text = "minutes";
            // 
            // SetupCloseButton
            // 
            this.SetupCloseButton.Location = new System.Drawing.Point(170, 175);
            this.SetupCloseButton.Name = "SetupCloseButton";
            this.SetupCloseButton.Size = new System.Drawing.Size(155, 30);
            this.SetupCloseButton.TabIndex = 8;
            this.SetupCloseButton.Text = "Close";
            this.SetupCloseButton.UseVisualStyleBackColor = true;
            this.SetupCloseButton.Click += new System.EventHandler(this.SetupCloseButton_Click);
            // 
            // TaskbarCheckBox
            // 
            this.TaskbarCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskbarCheckBox.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.TaskbarCheckBox.ForeColor = System.Drawing.Color.White;
            this.TaskbarCheckBox.Location = new System.Drawing.Point(240, 135);
            this.TaskbarCheckBox.Name = "TaskbarCheckBox";
            this.TaskbarCheckBox.Size = new System.Drawing.Size(85, 20);
            this.TaskbarCheckBox.TabIndex = 9;
            this.TaskbarCheckBox.Text = "Hide Taskbar";
            this.TaskbarCheckBox.UseVisualStyleBackColor = true;
            // 
            // SetupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.TaskbarCheckBox);
            this.Controls.Add(this.SetupCloseButton);
            this.Controls.Add(this.BreakMinutesLabel);
            this.Controls.Add(this.FocusMinutesLabel);
            this.Controls.Add(this.SetupStartButton);
            this.Controls.Add(this.BreakPromptTextBox);
            this.Controls.Add(this.BreakPromptLabel);
            this.Controls.Add(this.FocusPromptTextBox);
            this.Controls.Add(this.FocusPromptLabel);
            this.Controls.Add(this.SetupTitleLabel);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SetupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Focus Timer";
            this.Load += new System.EventHandler(this.SetupPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SetupTitleLabel;
        private System.Windows.Forms.Label FocusPromptLabel;
        private System.Windows.Forms.TextBox FocusPromptTextBox;
        private System.Windows.Forms.Label BreakPromptLabel;
        private System.Windows.Forms.TextBox BreakPromptTextBox;
        private System.Windows.Forms.Button SetupStartButton;
        private System.Windows.Forms.Label FocusMinutesLabel;
        private System.Windows.Forms.Label BreakMinutesLabel;
        private System.Windows.Forms.Button SetupCloseButton;
        private System.Windows.Forms.CheckBox TaskbarCheckBox;
    }
}