namespace FocusTimerPrototype
{
    partial class PreFocusPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreFocusPage));
            this.PreFocusTitleLabel = new System.Windows.Forms.Label();
            this.FocusInstructionLabel = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
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
            this.PreFocusTitleLabel.TabIndex = 0;
            this.PreFocusTitleLabel.Text = "Focus Time";
            this.PreFocusTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FocusInstructionLabel
            // 
            this.FocusInstructionLabel.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.FocusInstructionLabel.Location = new System.Drawing.Point(10, 50);
            this.FocusInstructionLabel.Name = "FocusInstructionLabel";
            this.FocusInstructionLabel.Size = new System.Drawing.Size(315, 110);
            this.FocusInstructionLabel.TabIndex = 1;
            this.FocusInstructionLabel.Text = resources.GetString("FocusInstructionLabel.Text");
            this.FocusInstructionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // beginButton
            // 
            this.beginButton.ForeColor = System.Drawing.Color.Black;
            this.beginButton.Location = new System.Drawing.Point(9, 169);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(155, 30);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "Begin Time";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.ForeColor = System.Drawing.Color.Black;
            this.ReturnButton.Location = new System.Drawing.Point(170, 169);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(155, 30);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Back to Setup";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // PreFocusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.FocusInstructionLabel);
            this.Controls.Add(this.PreFocusTitleLabel);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PreFocusPage";
            this.ShowIcon = false;
            this.Text = "Focus Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PreFocusTitleLabel;
        private System.Windows.Forms.Label FocusInstructionLabel;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}