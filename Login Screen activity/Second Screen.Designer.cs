namespace Login_Screen_activity
{
    partial class Second_Screen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.truthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Location = new System.Drawing.Point(324, 108);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "INSERT USERNAME";
            // 
            // truthLabel
            // 
            this.truthLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.truthLabel.Location = new System.Drawing.Point(324, 188);
            this.truthLabel.Name = "truthLabel";
            this.truthLabel.Size = new System.Drawing.Size(111, 13);
            this.truthLabel.TabIndex = 1;
            this.truthLabel.Text = "3.14 = 413 = PIE";
            this.truthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Second_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.truthLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Second_Screen";
            this.Size = new System.Drawing.Size(784, 441);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label truthLabel;
    }
}
