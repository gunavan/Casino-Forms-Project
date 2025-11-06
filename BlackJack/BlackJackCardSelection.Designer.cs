namespace Casino_Forms_Project
{
    partial class BlackJackCardSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cvComboBox = new System.Windows.Forms.ComboBox();
            this.hCheckBox = new System.Windows.Forms.CheckBox();
            this.dCheckBox = new System.Windows.Forms.CheckBox();
            this.sCheckBox = new System.Windows.Forms.CheckBox();
            this.cCheckBox = new System.Windows.Forms.CheckBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Card Value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 53);
            this.label2.TabIndex = 9;
            this.label2.Text = "Card Suit:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cvComboBox
            // 
            this.cvComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvComboBox.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvComboBox.FormattingEnabled = true;
            this.cvComboBox.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.cvComboBox.Location = new System.Drawing.Point(207, 13);
            this.cvComboBox.Name = "cvComboBox";
            this.cvComboBox.Size = new System.Drawing.Size(148, 53);
            this.cvComboBox.TabIndex = 10;
            // 
            // hCheckBox
            // 
            this.hCheckBox.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hCheckBox.Location = new System.Drawing.Point(208, 84);
            this.hCheckBox.Name = "hCheckBox";
            this.hCheckBox.Size = new System.Drawing.Size(69, 52);
            this.hCheckBox.TabIndex = 11;
            this.hCheckBox.Text = "♥";
            this.hCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hCheckBox.UseVisualStyleBackColor = true;
            this.hCheckBox.CheckedChanged += new System.EventHandler(this.hCheckBox_CheckedChanged);
            // 
            // dCheckBox
            // 
            this.dCheckBox.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dCheckBox.Location = new System.Drawing.Point(286, 84);
            this.dCheckBox.Name = "dCheckBox";
            this.dCheckBox.Size = new System.Drawing.Size(69, 52);
            this.dCheckBox.TabIndex = 11;
            this.dCheckBox.Text = "♦";
            this.dCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dCheckBox.UseVisualStyleBackColor = true;
            this.dCheckBox.CheckedChanged += new System.EventHandler(this.dCheckBox_CheckedChanged);
            // 
            // sCheckBox
            // 
            this.sCheckBox.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCheckBox.Location = new System.Drawing.Point(207, 142);
            this.sCheckBox.Name = "sCheckBox";
            this.sCheckBox.Size = new System.Drawing.Size(69, 52);
            this.sCheckBox.TabIndex = 11;
            this.sCheckBox.Text = "♠";
            this.sCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sCheckBox.UseVisualStyleBackColor = true;
            this.sCheckBox.CheckedChanged += new System.EventHandler(this.sCheckBox_CheckedChanged);
            // 
            // cCheckBox
            // 
            this.cCheckBox.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCheckBox.Location = new System.Drawing.Point(282, 142);
            this.cCheckBox.Name = "cCheckBox";
            this.cCheckBox.Size = new System.Drawing.Size(69, 52);
            this.cCheckBox.TabIndex = 11;
            this.cCheckBox.Text = "♣";
            this.cCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cCheckBox.UseVisualStyleBackColor = true;
            this.cCheckBox.CheckedChanged += new System.EventHandler(this.cCheckBox_CheckedChanged);
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(23, 200);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(332, 48);
            this.doneButton.TabIndex = 12;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // BlackJackCardSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 260);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.dCheckBox);
            this.Controls.Add(this.sCheckBox);
            this.Controls.Add(this.cCheckBox);
            this.Controls.Add(this.hCheckBox);
            this.Controls.Add(this.cvComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BlackJackCardSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BlackJackCardSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cvComboBox;
        private System.Windows.Forms.CheckBox hCheckBox;
        private System.Windows.Forms.CheckBox dCheckBox;
        private System.Windows.Forms.CheckBox sCheckBox;
        private System.Windows.Forms.CheckBox cCheckBox;
        private System.Windows.Forms.Button doneButton;
    }
}