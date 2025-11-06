using System;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackJackForm
    {
        private void oneButton_Click(object sender, EventArgs e)
        {
            bet += 1;
            currentBetLabel.Text = bet.ToString("C");
            experimentalButton.Visible = false;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            bet += 5;
            currentBetLabel.Text = bet.ToString("C");
            experimentalButton.Visible = false;
        }

        private void tenButton_Click(object sender, EventArgs e)
        {
            bet += 10;
            currentBetLabel.Text = bet.ToString("C");
            experimentalButton.Visible = false;
        }

        private void twfivButton_Click(object sender, EventArgs e)
        {
            bet += 25;
            currentBetLabel.Text = bet.ToString("C");
            experimentalButton.Visible = false;
        }

        private void hundButton_Click(object sender, EventArgs e)
        {
            bet += 100;
            currentBetLabel.Text = bet.ToString("C");
            experimentalButton.Visible = false;
        }

        private void clearBetButton_Click(object sender, EventArgs e)
        {
            bet = 0;
            currentBetLabel.Text = bet.ToString("C");
            experimentalButton.Visible = false;
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            PlaceBet();
            experimentalButton.Visible = false;
        }

        private void allInButton_Click(object sender, EventArgs e)
        {
            bet = GlobalData.getRiskMoney();
            currentBetLabel.Text = bet.ToString("C");
            PlaceBet();
        }

        public int getBet()
        {
            return bet;
        }

        public void setBet(int amount)
        {
            bet = amount;
            currentBetLabel.Text = bet.ToString("C");
        }

        public void PlaceBet()
        {
            if (bet > GlobalData.riskMoney) {
                MessageBox.Show("You cannot bet more than you have");
                bet = 0;
                currentBetLabel.Text = bet.ToString("C");
                return; }
            if (bet == 0) {
                MessageBox.Show("You must place a bet before starting");
                return; }
            GlobalData.riskMoney -= bet;
            playerMoneyLabel.Text = GlobalData.riskMoney.ToString("C");
            // cycle buttons
            gameStart = true;
            // experimental
            b.SetStarted(true);
            Screen();
            StartGame();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // BlackJackForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(282, 253);
        //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        //    this.Name = "BlackJackForm";
        //    this.ResumeLayout(false);

        //}
    }
}
