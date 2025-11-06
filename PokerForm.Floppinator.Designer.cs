namespace Casino_Forms_Project
{
    partial class PkFloppinator
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
            this.playerEHLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerEHLabel
            // 
            this.playerEHLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerEHLabel.Font = new System.Drawing.Font("Javanese Text", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerEHLabel.Location = new System.Drawing.Point(-6, 9);
            this.playerEHLabel.Name = "playerEHLabel";
            this.playerEHLabel.Size = new System.Drawing.Size(915, 222);
            this.playerEHLabel.TabIndex = 11;
            this.playerEHLabel.Text = "🂢 🂢 🂢 🂢 🂢";
            this.playerEHLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PkFloppinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 253);
            this.Controls.Add(this.playerEHLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PkFloppinator";
            this.Text = "p";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playerEHLabel;
    }
}