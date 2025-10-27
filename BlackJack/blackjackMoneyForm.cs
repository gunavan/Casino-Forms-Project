using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackjackMoneyForm : Form
    {
        public BlackjackMoneyForm()
        {
            InitializeComponent();
            playerMoneyLabel.Text = GlobalData.playerMoney.ToString("C");
            this.ControlBox = false;
            textBox1.KeyDown += textbox1_KeyDown;
        }
        private void textbox1_KeyDown (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                okButton_Click(sender, EventArgs.Empty);
                // e.SuppressKeyPress = true;
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int t))
            {
                MessageBox.Show("Must be a number");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            if (int.Parse(textBox1.Text) > GlobalData.playerMoney) {
                MessageBox.Show("You dont have that much money");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            if (int.Parse(textBox1.Text) < 0) {
                MessageBox.Show("Must be a whole number");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            if (textBox1.Text == "" || int.Parse(textBox1.Text) == 0) {                
                MessageBox.Show("Amount cannot be empty");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }

            GlobalData.riskMoney = int.Parse(textBox1.Text);
            GlobalData.playerMoney -= GlobalData.riskMoney;
            this.Close();
        }
    }
}
