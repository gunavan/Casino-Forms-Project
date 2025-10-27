﻿using System;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackJackForm
    {
        private void Screen()
        {
            if (gameStart)
            {
                // phase 1
                oneButton.Visible = false; fiveButton.Visible = false; tenButton.Visible = false; twfivButton.Visible = false; hundButton.Visible = false;
                clearBetButton.Visible = false; betButton.Visible = false;
                // phase 2
                hitButton.Visible = true; standButton.Visible = true;
                playerExpandedHand.Visible = true; dealerExpandedHand.Visible = true;
                // textboxes refresh
                playerExpandedHand.Text = HandPrint(playerCards); dealerExpandedHand.Text = dealerExpandedHand.Text;
                playerHandLabel.Visible = true; dealerHandLabel.Visible = true;
                playerHandLabel.Text = playerHand.ToString(); dealerHandLabel.Text = dealerHandLabel.Text;
                winloseLabel.Text = winloseLabel.Text; reasonLabel.Text = reasonLabel.Text;
                cardsRemainingLabel.Text = decks.Count.ToString();
                // menu items
                playerHandMenuItem.Visible = true;
                dealerHandMenuItem.Visible = true;
                if (playerHand == 21) { hitButton.Visible = false; }
            }
            else
            {
                playerMoneyLabel.Text = GlobalData.riskMoney.ToString("C");
                playerBalanceLabel.Text = GlobalData.playerMoney.ToString("C");
                cardsRemainingLabel.Text = decks.Count.ToString();
                // reset bet
                bet = 0; currentBetLabel.Text = "";
                // cycle buttons
                // phase 1
                oneButton.Visible = true; fiveButton.Visible = true; tenButton.Visible = true; twfivButton.Visible = true; hundButton.Visible = true;
                clearBetButton.Visible = true; betButton.Visible = true;
                winloseLabel.Visible = false; reasonLabel.Visible = false;
                // phase 2
                hitButton.Visible = false; standButton.Visible = false; // b
                playerExpandedHand.Visible = false; dealerExpandedHand.Visible = false;
                // reset hands and textboxes
                playerHand = 0; dealerHand = 0;
                pc1 = ""; pc2 = ""; dc1 = ""; dc2 = "";
                playerExpandedHand.Text = ""; dealerExpandedHand.Text = "";
                // clearing hands
                playerCards.Clear(); dealerCards.Clear();
                // menu items
                playerHandMenuItem.Visible = false;
                dealerHandMenuItem.Visible = false;
                // for testing
                playerHandLabel.Visible = false; dealerHandLabel.Visible = false;
                playerHandLabel.Text = ""; dealerHandLabel.Text = "";


                winloseLabel.Text = "";
            }
        }
    }
}

