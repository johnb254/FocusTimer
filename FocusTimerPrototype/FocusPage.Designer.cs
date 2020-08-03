namespace FocusTimerPrototype
{
    partial class FocusPage
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
            this.FocusLabel = new System.Windows.Forms.Label();
            this.FocusReturnButton = new System.Windows.Forms.Button();
            this.FocusTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FocusLabel
            // 
            this.FocusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusLabel.AutoSize = true;
            this.FocusLabel.Font = new System.Drawing.Font("Noto Sans Cond", 60F);
            this.FocusLabel.Location = new System.Drawing.Point(40, 10);
            this.FocusLabel.Name = "FocusLabel";
            this.FocusLabel.Size = new System.Drawing.Size(254, 109);
            this.FocusLabel.TabIndex = 0;
            this.FocusLabel.Text = "FOCUS";
            // 
            // FocusReturnButton
            // 
            this.FocusReturnButton.ForeColor = System.Drawing.Color.Black;
            this.FocusReturnButton.Location = new System.Drawing.Point(12, 169);
            this.FocusReturnButton.Name = "FocusReturnButton";
            this.FocusReturnButton.Size = new System.Drawing.Size(310, 30);
            this.FocusReturnButton.TabIndex = 4;
            this.FocusReturnButton.Text = "Back to Setup";
            this.FocusReturnButton.UseVisualStyleBackColor = true;
            this.FocusReturnButton.Click += new System.EventHandler(this.FocusReturnButton_Click);
            // 
            // FocusTimer
            // 
            this.FocusTimer.Interval = 999999999;
            this.FocusTimer.Tick += new System.EventHandler(this.FocusTimer_Tick);
            // 
            // FocusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.FocusReturnButton);
            this.Controls.Add(this.FocusLabel);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FocusPage";
            this.Text = "FocusPage";
            this.Load += new System.EventHandler(this.FocusPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FocusLabel;
        private System.Windows.Forms.Button FocusReturnButton;
        private System.Windows.Forms.Timer FocusTimer;
    }
}