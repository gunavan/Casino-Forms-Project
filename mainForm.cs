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
            playerMoneyLabel.Text = GlobalData.playerMoney.ToString("C");
        }

        private void blackjackButton_Click(object sender, EventArgs e)
        {
            BlackJackForm bjf = new BlackJackForm();
            bjf.Show();
            GlobalData.playerMoney += GlobalData.riskMoney;
            playerMoneyLabel.Text = GlobalData.playerMoney.ToString("C");
        }

        private void pokerButton_Click(object sender, EventArgs e)
        {
            //PokerForm pf = new PokerForm();
            //pf.ShowDialog();
            GlobalData.playerMoney += GlobalData.riskMoney;
            playerMoneyLabel.Text = GlobalData.playerMoney.ToString("C");
        }
    }
}
