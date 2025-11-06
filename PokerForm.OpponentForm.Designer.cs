namespace Casino_Forms_Project
{
    partial class PkOppForm
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
            this.handValueLabel = new System.Windows.Forms.Label();
            this.printedHandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // handValueLabel
            // 
            this.handValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.handValueLabel.Font = new System.Drawing.Font("Javanese Text", 13.2F);
            this.handValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.handValueLabel.Location = new System.Drawing.Point(9, 263);
            this.handValueLabel.Name = "handValueLabel";
            this.handValueLabel.Size = new System.Drawing.Size(87, 52);
            this.handValueLabel.TabIndex = 13;
            this.handValueLabel.Text = "126";
            this.handValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // printedHandLabel
            // 
            this.printedHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.printedHandLabel.Font = new System.Drawing.Font("Javanese Text", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printedHandLabel.Location = new System.Drawing.Point(-20, 62);
            this.printedHandLabel.Name = "printedHandLabel";
            this.printedHandLabel.Size = new System.Drawing.Size(480, 222);
            this.printedHandLabel.TabIndex = 12;
            this.printedHandLabel.Text = "🂢 🂢";
            this.printedHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PkOppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 309);
            this.Controls.Add(this.handValueLabel);
            this.Controls.Add(this.printedHandLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PkOppForm";
            this.Text = "Opponent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label handValueLabel;
        private System.Windows.Forms.Label printedHandLabel;
    }
}