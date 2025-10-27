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
            playerMoneyLabel.Text = GlobalData.playerMoney.ToString("C");
        }

        private void blackjackButton_Click(object sender, EventArgs e)
        {
            BlackJackForm bjf = new BlackJackForm();
            bjf.ShowDialog();
            GlobalData.playerMoney += GlobalData.riskMoney;
            playerMoneyLabel.Text = GlobalData.playerMoney.ToString("C");
        }
    }
}
