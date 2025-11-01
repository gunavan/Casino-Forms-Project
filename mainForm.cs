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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormClosed += MainForm_FormClosed;
            playerMoneyLabel.Text = GlobalData.getPlayerMoney().ToString("C");
        }

        private void blackjackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BlackJackForm bjf = new BlackJackForm(this);
            bjf.Show();
            //UpdateLabels();
        }

        private void pokerButton_Click(object sender, EventArgs e)
        {
            //PokerForm pf = new PokerForm();
            //pf.ShowDialog();
            //GlobalData.getPlayerMoney() += GlobalData.riskMoney;
            playerMoneyLabel.Text = GlobalData.getPlayerMoney().ToString("C");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void UpdateLabels()
        {
            playerMoneyLabel.Text = GlobalData.getPlayerMoney().ToString("C");
        }
    }
}
