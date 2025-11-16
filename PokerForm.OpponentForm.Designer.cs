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
            this.chipLabel = new System.Windows.Forms.Label();
            this.currBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.handValueLabel.Text = "value";
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
            this.printedHandLabel.Text = "🂢 🂢y";
            this.printedHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chipLabel
            // 
            this.chipLabel.BackColor = System.Drawing.Color.Transparent;
            this.chipLabel.Font = new System.Drawing.Font("Javanese Text", 13.2F);
            this.chipLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chipLabel.Location = new System.Drawing.Point(12, 9);
            this.chipLabel.Name = "chipLabel";
            this.chipLabel.Size = new System.Drawing.Size(87, 52);
            this.chipLabel.TabIndex = 13;
            this.chipLabel.Text = "chip";
            this.chipLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // currBetLabel
            // 
            this.currBetLabel.BackColor = System.Drawing.Color.Transparent;
            this.currBetLabel.Font = new System.Drawing.Font("Javanese Text", 13.2F);
            this.currBetLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.currBetLabel.Location = new System.Drawing.Point(308, 263);
            this.currBetLabel.Name = "currBetLabel";
            this.currBetLabel.Size = new System.Drawing.Size(117, 52);
            this.currBetLabel.TabIndex = 13;
            this.currBetLabel.Text = "$$$";
            this.currBetLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 13.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(221, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 52);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PkOppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 309);
            this.Controls.Add(this.chipLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currBetLabel);
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
        private System.Windows.Forms.Label chipLabel;
        private System.Windows.Forms.Label currBetLabel;
        private System.Windows.Forms.Label label2;
    }
}