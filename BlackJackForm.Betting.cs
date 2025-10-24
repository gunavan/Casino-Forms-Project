using System;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackjackForm
    {
        private void oneButton_Click(object sender, EventArgs e)
        {
            bet += 1;
            currentBetLabel.Text = bet.ToString("C");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            bet += 5;
            currentBetLabel.Text = bet.ToString("C");
        }

        private void tenButton_Click(object sender, EventArgs e)
        {
            bet += 10;
            currentBetLabel.Text = bet.ToString("C");
        }

        private void twfivButton_Click(object sender, EventArgs e)
        {
            bet += 25;
            currentBetLabel.Text = bet.ToString("C");
        }

        private void hundButton_Click(object sender, EventArgs e)
        {
            bet += 100;
            currentBetLabel.Text = bet.ToString("C");
        }

        private void clearBetButton_Click(object sender, EventArgs e)
        {
            bet = 0;
            currentBetLabel.Text = bet.ToString("C");
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (bet > GlobalData.riskMoney) {
                MessageBox.Show("You cannot bet more than you have");
                bet = 0;
                currentBetLabel.Text = bet.ToString("C");
                return;
            }
            if (bet == 0) {
                MessageBox.Show("You must place a bet before starting");
                return;
            }
            GlobalData.riskMoney -= bet;
            playerMoneyLabel.Text = GlobalData.riskMoney.ToString("C");
            // cycle buttons
            gameStart = true;

            screen();

            // testing
            playerHandLabel.Visible = true; dealerHandLabel.Visible = true;

            // start
            startGame();
        }
    }

}
