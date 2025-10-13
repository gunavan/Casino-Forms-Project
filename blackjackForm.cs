using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackjackForm : Form
    {
        // variables
        int bet = 0;
        int playerHand = 0, dealerHand = 0;
        string pc1, pc2, dc1, dc2;
        int DECKAMMOUNTS = 4;
        bool gameStart = false;
        // suits and values from deck in main
        List<string> suits = new List<string>();
        List<string> values = new List<string>();
        Dictionary<string, string> ascii = new Dictionary<string, string>(GlobalData.asciiCards);
        private Random rng = new Random();
        // ace counter
        int playerAces = 0, dealerAces = 0;
        public BlackjackForm()
        {
            InitializeComponent();
            BlackjackMoneyForm bjmf = new BlackjackMoneyForm();
            // adding decks
            suits = new List<string>(addDecks("suits", DECKAMMOUNTS));
            values = new List<string>(addDecks("values", DECKAMMOUNTS));
            // getting money to enter
            bjmf.ShowDialog();
            playerMoneyLabel.Text = GlobalData.riskMoney.ToString("C");
            playerBalanceLabel.Text = GlobalData.playerMoney.ToString("C");
            // remaining cards
            cardsRemainingLabel.Text = values.Count.ToString();
        }

        private static List<string> addDecks(string deck, int count)
        {
            List<string> r = new List<string>();
            List<string> t = new List<string>();
            // getting suits or values
            if (deck == "suits") { t = new List<string>(GlobalData.deckSuits); }
            else if (deck == "values") { t = new List<string>(GlobalData.deckValues); }
            // adding copies
            while (count-- > 0) { r.AddRange(t); }

            return r;
        }

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

        private void screen()
        {
            if (gameStart)
            {
                // phase 1
                oneButton.Visible = false; fiveButton.Visible = false; tenButton.Visible = false; twfivButton.Visible = false; hundButton.Visible = false;
                clearBetButton.Visible = false; betButton.Visible = false;
                // phase 2
                hitButton.Visible = true; standButton.Visible = true;
                playerExpandedHand.Visible = true; dealerExpandedHand.Visible = true;
            }
            else
            {
                playerMoneyLabel.Text = GlobalData.riskMoney.ToString("C");
                playerBalanceLabel.Text = GlobalData.playerMoney.ToString("C");
                cardsRemainingLabel.Text = values.Count.ToString();
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
                // aces
                playerAces = 0; dealerAces = 0;

                // for testing
                playerHandLabel.Visible = false; dealerHandLabel.Visible = false;
                playerHandLabel.Text = ""; dealerHandLabel.Text = "";

                winloseLabel.Text = "";
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (bet > GlobalData.riskMoney)
            {
                MessageBox.Show("You cannot bet more than you have");
                bet = 0;
                currentBetLabel.Text = bet.ToString("C");
                return;
            }
            if (bet == 0)
            {
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
        private void hitButton_Click(object sender, EventArgs e)
        {
            // new card
            string newCard = cardFromDeck();
            playerHand += cardValue(newCard);
            // checking for ace
            if (newCard == "A") { playerAces++; }
            // if over 21 with new card, and if ace in first hand
            if (playerHand > 21 && playerAces != 0) {
                playerHand -= 10;
                playerAces--;
            }
            // output
            playerExpandedHand.Text += " " + ascii[newCard];
            
            // for testing
            playerHandLabel.Text = playerHand.ToString();

            // check if bust, removes hit so player doesnt bust at 21
            if (playerHand > 21) { playerLose(1); }
            if (playerHand == 21) { hitButton.Visible = false; }
            // cards remaining
            cardsRemainingLabel.Text = values.Count.ToString();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            string ncards = " ";
            // dealer until 17
            while (dealerHand < 17) {
                string newCard = cardFromDeck();
                dealerHand += cardValue(newCard);
                // dealer ace counter
                if (newCard == "A") { dealerAces++; }
                if (dealerHand > 21 && dealerAces != 0) {
                    dealerHand -= 10;
                    dealerAces--;
                }
                ncards += ascii[newCard] + " ";
            }
            dealerExpandedHand.Text = ascii[dc1] + " " + ascii[dc2] + ncards;
            // for testing
            dealerHandLabel.Text = dealerHand.ToString();
            // reasons
            if (dealerHand == playerHand) { push(); }
            else if (dealerHand > 21) { playerWin(1); }
            else if (dealerHand > playerHand) { playerLose(2); }
            else { playerWin(2); }
            // card remaining
            cardsRemainingLabel.Text = values.Count.ToString();
        }

        private string cardFromDeck()
        {
            int index = rng.Next(0, values.Count);
            string temp = values[index] + suits[index];
            suits.RemoveAt(index);
            values.RemoveAt(index);
            return temp;
        }

        private int cardValue(string card)
        {
            string rank;
            // if 10
            if (card.Length == 3) { rank = card.Substring(0, 2); }
            else { rank = card.Substring(0,1); }
            if (rank == "A") { return 11; }
            else if (rank == "J" || rank == "Q" || rank == "K") { return 10; }
            else { return int.Parse(rank); }
        }

        private void startGame()
        {
            // getting random cards from deck
            //pc1 = cardFromDeck();
            pc1 = cardFromDeck();
            pc2 = cardFromDeck();
            dc1 = cardFromDeck();
            dc2 = cardFromDeck();
            // card value
            playerHand = cardValue(pc1) + cardValue(pc2);
            dealerHand = cardValue(dc1) + cardValue(dc2);
            //string fakeDealer = dc1;
            // counting aces
            if (pc1 == "A") { playerAces++; } if (pc2 == "A") { playerAces++; }
            if (dc1 == "A") { dealerAces++; } if (dc2 == "A") { dealerAces++; }
            // checking if over 21 on first hand. player and dealer
            if (playerHand > 21 && (playerAces != 0)) {
                playerHand -= 10;
                playerAces--;
            } else if (dealerHand > 21 && (dealerAces != 0)) {
                dealerHand -= 10;
                dealerAces--;   
            }
            // if player is lucky
            if (playerHand == 21) { hitButton.Visible = false; }
            // output
            playerExpandedHand.Text = ascii[pc1] + " " + ascii[pc2];
            dealerExpandedHand.Text = ascii[dc1] + " + ?";

            // for testing
            playerHandLabel.Text = playerHand.ToString();
            dealerHandLabel.Text = dealerHand.ToString();

            // cards remaining
            cardsRemainingLabel.Text = values.Count.ToString();
        }

        private void restartGame()
        {
            // if no money left
            if (GlobalData.riskMoney <= 0) {
                MessageBox.Show("You are out of money! \nBetter luck Next Time :(");
                this.Close();
            }
            screen();
            // for testing
            playerHandLabel.Visible = false; dealerHandLabel.Visible = false;
            playerHandLabel.Text = ""; dealerHandLabel.Text = "";

            winloseLabel.Text = "";
            // if half cards are remaining of deck ammounts, shuffle
            if (values.Count < (52 * DECKAMMOUNTS) / 2) { shuffle(); }
            // cards remaining
            cardsRemainingLabel.Text = values.Count.ToString();
        }

        private async void shuffle()
        {
            // problem here
            suits.Clear();
            values.Clear();
            suits = new List<string>(addDecks("suits", DECKAMMOUNTS));
            values = new List<string>(addDecks("values", DECKAMMOUNTS));
            // textbox
            shuffleLabel.Visible = true;
            await waitTimer(3);
            shuffleLabel.Visible = false;
        }

        private async void playerWin(int i)
        {
            string temp = "";
            winloseLabel.Visible = true; reasonLabel.Visible = true;
            winloseLabel.Text = "YOU WIN!";
            // reasons
            if (i == 1) { temp = "Dealer bust!"; }
            else if (i == 2) { temp = "Hand beats dealer's!"; }
            reasonLabel.Text = temp + "\n x2 payout";
            // hide buttons
            hitButton.Visible = false;
            standButton.Visible = false;
            await waitTimer(3);
            // updater
            GlobalData.riskMoney += (bet * 2);
            playerMoneyLabel.Text = (GlobalData.riskMoney).ToString("C");
            gameStart = false;
            restartGame();
        }

        private async void playerLose(int i)
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
            gameStart = false;
            restartGame();
        }

        private async void push()
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
            gameStart = false;
            restartGame();
        }

        private async Task waitTimer(int secs)
        {
            await Task.Delay(secs * 1000);
        }

        private void shuffleMenuItem_Click(object sender, EventArgs e)
        {
            shuffle();
            screen();
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            GlobalData.riskMoney += 500;
            screen();
        }

        private void deckQuantityMenuItem_Click(object sender, EventArgs e)
        {
            DECKAMMOUNTS++;
            shuffle();
            screen();
        }

        private void removeDeckMenuItem_Click(object sender, EventArgs e)
        {
            if (DECKAMMOUNTS == 1) {
                MessageBox.Show("Cannot have less than 1 deck");
                return;
            }
            DECKAMMOUNTS--;
            shuffle();
            screen();
        }

        private void refreshScreenMenuItem_Click(object sender, EventArgs e)
        {
            screen();
        }
    }
}
/* future changes
visuals
better gui
split
*/