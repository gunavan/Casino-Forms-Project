﻿namespace Casino_Forms_Project
{
    partial class DealerCardForm
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
            this.dealerEHLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealerEHLabel
            // 
            this.dealerEHLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealerEHLabel.Font = new System.Drawing.Font("Javanese Text", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerEHLabel.Location = new System.Drawing.Point(12, 18);
            this.dealerEHLabel.Name = "dealerEHLabel";
            this.dealerEHLabel.Size = new System.Drawing.Size(1252, 245);
            this.dealerEHLabel.TabIndex = 9;
            this.dealerEHLabel.Text = "d hand";
            this.dealerEHLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DealerCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 281);
            this.Controls.Add(this.dealerEHLabel);
            this.Name = "DealerCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealer\'s Cards";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dealerEHLabel;
    }
}