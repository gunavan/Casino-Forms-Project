namespace Casino_Forms_Project
{
    partial class PkButtonsForm
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
            this.foldButton = new System.Windows.Forms.Button();
            this.raiseButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.allInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foldButton
            // 
            this.foldButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.foldButton.Location = new System.Drawing.Point(221, 115);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(203, 97);
            this.foldButton.TabIndex = 0;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = true;
            // 
            // raiseButton
            // 
            this.raiseButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.raiseButton.Location = new System.Drawing.Point(221, 12);
            this.raiseButton.Name = "raiseButton";
            this.raiseButton.Size = new System.Drawing.Size(203, 97);
            this.raiseButton.TabIndex = 0;
            this.raiseButton.Text = "Raise";
            this.raiseButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.checkButton.Location = new System.Drawing.Point(12, 12);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(203, 97);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // allInButton
            // 
            this.allInButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold);
            this.allInButton.Location = new System.Drawing.Point(12, 113);
            this.allInButton.Name = "allInButton";
            this.allInButton.Size = new System.Drawing.Size(203, 97);
            this.allInButton.TabIndex = 0;
            this.allInButton.Text = "All In";
            this.allInButton.UseVisualStyleBackColor = true;
            // 
            // PkButtonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 222);
            this.Controls.Add(this.allInButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.raiseButton);
            this.Controls.Add(this.foldButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PkButtonsForm";
            this.Text = "what to do...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PkButtonsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button foldButton;
        private System.Windows.Forms.Button raiseButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button allInButton;
    }
}