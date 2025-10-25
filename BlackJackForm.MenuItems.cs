using System;
using System.Configuration;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackjackForm
    {
        private void pCard1MenuItem_Click(object sender, EventArgs e)
        {
            bjcs.ShowDialog();
            // its not removing if pc1 was already a ace
            // check if pc1 was ace, subtract if it was
            // then add new card and add ace if needed
            pc1 = bjcs.Card;
            updatePlayerHand();
            Screen();
        }

        private void pCard2MenuItem_Click(object sender, EventArgs e)
        {
            bjcs.ShowDialog();
            pc2 = bjcs.Card;
            updatePlayerHand();
            Screen();
        }
        private void updatePlayerHand()
        {
            playerHand = CardValueInt(pc1) + CardValueInt(pc2);
            if (pc1.Substring(0, 1) == "A" || pc2.Substring(0, 1) == "A") { playerAces--; }
            //over21Checker("player");
            playerExpandedHand.Text = ascii[pc1] + " " + ascii[pc2];
            if (playerHand > 21) {
                hitButton.Visible = false;
            }
        }

        private void pNewCardMenuItem_Click(object sender, EventArgs e)
        {
            bjcs.ShowDialog();
            // new card
            string newCard = bjcs.Card;
            playerHand += CardValueInt(newCard);
            //over21Checker("player");
            // output
            playerExpandedHand.Text += " " + ascii[newCard];

            // for testing
            playerHandLabel.Text = playerHand.ToString();

            // check if bust, removes hit so player doesnt bust at 21
            if (playerHand > 21) { PlayerLose(1); }
            if (playerHand == 21) { hitButton.Visible = false; }
            // cards remaining
            cardsRemainingLabel.Text = decks.Count.ToString();
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
