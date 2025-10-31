namespace Casino_Forms_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.blackjackButton = new System.Windows.Forms.Button();
            this.playerMoneyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pokerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome! to the Epic Casino!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blackjackButton
            // 
            this.blackjackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blackjackButton.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold);
            this.blackjackButton.Location = new System.Drawing.Point(19, 134);
            this.blackjackButton.Name = "blackjackButton";
            this.blackjackButton.Size = new System.Drawing.Size(310, 90);
            this.blackjackButton.TabIndex = 1;
            this.blackjackButton.Text = "Black Jack";
            this.blackjackButton.UseVisualStyleBackColor = false;
            this.blackjackButton.Click += new System.EventHandler(this.blackjackButton_Click);
            // 
            // playerMoneyLabel
            // 
            this.playerMoneyLabel.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerMoneyLabel.Location = new System.Drawing.Point(109, 9);
            this.playerMoneyLabel.Name = "playerMoneyLabel";
            this.playerMoneyLabel.Size = new System.Drawing.Size(170, 37);
            this.playerMoneyLabel.TabIndex = 6;
            this.playerMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Balance:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pokerButton
            // 
            this.pokerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pokerButton.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold);
            this.pokerButton.Location = new System.Drawing.Point(424, 134);
            this.pokerButton.Name = "pokerButton";
            this.pokerButton.Size = new System.Drawing.Size(310, 90);
            this.pokerButton.TabIndex = 1;
            this.pokerButton.Text = "Poker";
            this.pokerButton.UseVisualStyleBackColor = false;
            this.pokerButton.Click += new System.EventHandler(this.pokerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(767, 553);
            this.Controls.Add(this.playerMoneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pokerButton);
            this.Controls.Add(this.blackjackButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button blackjackButton;
        private System.Windows.Forms.Label playerMoneyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pokerButton;
    }
}

