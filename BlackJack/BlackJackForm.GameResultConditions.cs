using System;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackJackForm
    {
        private async void PlayerWin(int i)
        {
            string temp = "";
            winloseLabel.Visible = true; reasonLabel.Visible = true;
            winloseLabel.Text = "YOU WIN!";
            // reasons
            if (i == 1) { temp = "Dealer bust!"; }
            else if (i == 2) { temp = "Your Hand beats dealer's!"; }
            reasonLabel.Text = temp + "\n x2 payout";
            // hide buttons
            hitButton.Visible = false;
            standButton.Visible = false;
            await waitTimer(3);
            // updater
            GlobalData.riskMoney += (bet * 2);
            playerMoneyLabel.Text = (GlobalData.riskMoney).ToString("C");
            RestartGame();
        }

        private async void PlayerLose(int i)
        {
            string temp = "";
            winloseLabel.Visible = true; reasonLabel.Visible = true;
            winloseLabel.Text = "YOU LOSE!";
            // reasons
            if (i == 1) { temp = "Player bust!"; }
            else if (i == 2) { temp = "Dealer's hand beats your's!"; }
            reasonLabel.Text = temp + "\n no payout";
            // hide buttons
            hitButton.Visible = false;
            standButton.Visible = false;
            await waitTimer(3);
            RestartGame();
        }

        private async void Push()
        {
            winloseLabel.Visible = true; reasonLabel.Visible = true;
            winloseLabel.Text = "Push!";
            reasonLabel.Text = "You get your bet back!";
            // hide buttons
            hitButton.Visible = false;
            standButton.Visible = false;
            await waitTimer(3);
            // updater
            GlobalData.riskMoney += bet;
            playerMoneyLabel.Text = (GlobalData.riskMoney).ToString("C");
            RestartGame();
        }
    }
}