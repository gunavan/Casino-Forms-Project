using System;
using System.Configuration;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackJackForm
    {
        private void pCard1MenuItem_Click(object sender, EventArgs e)
        {
            BlackJackCardSelection bjcs = new BlackJackCardSelection();
            bjcs.ShowDialog();
            playerCards[0] = bjcs.Card;
            playerHand = HandValueFromCards(playerCards);
            Screen();
        }

        private void pCard2MenuItem_Click(object sender, EventArgs e)
        {
            BlackJackCardSelection bjcs = new BlackJackCardSelection();
            bjcs.ShowDialog();
            playerCards[1] = bjcs.Card;
            playerHand = HandValueFromCards(playerCards);
            Screen();
        }
        
        private void pNewCardMenuItem_Click(object sender, EventArgs e)
        {
            BlackJackCardSelection bjcs = new BlackJackCardSelection();
            bjcs.ShowDialog();
            playerCards.Add(bjcs.Card);
            playerHand = HandValueFromCards(playerCards);

            Screen();
        }

        private void dCard1MenuItem_Click(object sender, EventArgs e)
        {
            BlackJackCardSelection bjcs = new BlackJackCardSelection();
            bjcs.ShowDialog();
            dealerCards[0] = bjcs.Card;
            dealerHand = HandValueFromCards(dealerCards);
            dealerExpandedHand.Text = HandPrint(dealerCards);
            dealerHandLabel.Text = dealerHand.ToString();
            Screen();
        }

        private void dCard2MenuItem_Click(object sender, EventArgs e)
        {
            BlackJackCardSelection bjcs = new BlackJackCardSelection();
            bjcs.ShowDialog();
            dealerCards[1] = bjcs.Card;
            dealerHand = HandValueFromCards(dealerCards);
            dealerExpandedHand.Text = HandPrint(dealerCards);
            dealerHandLabel.Text = dealerHand.ToString();
            Screen();
        }

        private void dNewCardMenuItem_Click(object sender, EventArgs e)
        {
            BlackJackCardSelection bjcs = new BlackJackCardSelection();
            bjcs.ShowDialog();
            dealerCards.Add(bjcs.Card);
            dealerHand = HandValueFromCards(dealerCards);
            dealerExpandedHand.Text = HandPrint(dealerCards);
            dealerHandLabel.Text = dealerHand.ToString();
            Screen();
        }

        private void shuffleMenuItem_Click(object sender, EventArgs e)
        {
            Shuffle();
            Screen();
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            GlobalData.riskMoney += 500;
            Screen();
        }

        private void deckQuantityMenuItem_Click(object sender, EventArgs e)
        {
            DECKAMMOUNTS++;
            Shuffle();
            Screen();
        }

        private void removeDeckMenuItem_Click(object sender, EventArgs e)
        {
            if (DECKAMMOUNTS == 1)
            {
                MessageBox.Show("Cannot have less than 1 deck");
                return;
            }
            DECKAMMOUNTS--;
            Shuffle();
            Screen();
        }

        private void refreshScreenMenuItem_Click(object sender, EventArgs e)
        {
            Screen();
        }
    }
}
