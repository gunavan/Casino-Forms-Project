using System;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackJackForm
    {
        private async void PlayerWin(int i)
        {
            // updater
            GlobalData.riskMoney += (bet * 2);
            playerMoneyLabel.Text = (GlobalData.riskMoney).ToString("C");
            string temp = "";
            winloseLabel.Visible = true; reasonLabel.Visible = true;
            winloseLabel.Text = "You WIN!";
            // reasons
            if (i == 1) { temp = "Dealer bust!"; }
            else if (i == 2) { temp = "Your Hand beats dealer's!"; }
            reasonLabel.Text = temp + "\n x2 payout";
            if (experimental) {
                info.SetWinLose("YOU Win!"); info.SetReason(temp + "\n x2 payout");
                info.SetWinLoseVisibility(true); info.SetReasonVisibility(true);
                b.SetHitButtonsVisible(false); b.SetStandButtonsVisible(false);
            }
            // hide buttons
            hitButton.Visible = false;
            standButton.Visible = false;
            await waitTimer(3);
            if (experimental) { info.SetReasonVisibility(false); info.SetWinLoseVisibility(false); }
            RestartGame();
        }

        private async void PlayerLose(int i)
        {
            string temp = "";
            winloseLabel.Visible = true; reasonLabel.Visible = true;
            winloseLabel.Text = "You LOSE!";
            // reasons
            if (i == 1) { temp = "Player bust!"; }
            else if (i == 2) { temp = "Dealer's hand beats your's!"; }
            reasonLabel.Text = temp + "\n no payout";
            if (experimental) {
                info.SetWinLose("YOU Lose!"); info.SetReason(temp + "\n no payout");
                info.SetWinLoseVisibility(true); info.SetReasonVisibility(true);
                b.SetHitButtonsVisible(false); b.SetStandButtonsVisible(false); }
            // hide buttons
            hitButton.Visible = false;
            standButton.Visible = false;
            await waitTimer(3);
            if (experimental) { info.SetReasonVisibility(false); info.SetWinLoseVisibility(false); }
            RestartGame();
        }

        private async void Push()
        {
            // updater
            GlobalData.riskMoney += bet;
            playerMoneyLabel.Text = (GlobalData.riskMoney).ToString("C");
            winloseLabel.Visible = true; reasonLabel.Visible = true;
            winloseLabel.Text = "Push!"; reasonLabel.Text = "You get your bet back!";
            if (experimental) {
                info.SetWinLose("Push!"); info.SetReason("You get your bet back!");
                info.SetWinLoseVisibility(true); info.SetReasonVisibility(true);
                b.SetHitButtonsVisible(false); b.SetStandButtonsVisible(false); }                
            // hide buttons
            hitButton.Visible = false;
            standButton.Visible = false;    
            await waitTimer(3);
            if (experimental) { info.SetReasonVisibility(false); info.SetWinLoseVisibility(false); }
            RestartGame();
        }
    }
}