using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackjackForm : Form
    {
        // variables
        int bet = 0, playerHand = 0, dealerHand = 0, DECKAMMOUNTS = 4, playerAces = 0, dealerAces = 0;
        string pc1, pc2, dc1, dc2;
        bool gameStart = false;
        // deck from main
        List<string> playerCards = new List<string>();
        List<string> dealerCards = new List<string>();
        List<string> decks = new List<string>();
        Dictionary<string, string> ascii = new Dictionary<string, string>(GlobalData.asciiCards);
        private Random rng = new Random();
        // forms
        BlackJackCardSelection bjcs = new BlackJackCardSelection();
        public BlackjackForm()
        {
            InitializeComponent();
            BlackjackMoneyForm bjmf = new BlackjackMoneyForm();
            // adding decks
            decks = new List<string>(AddDecks(DECKAMMOUNTS));
            // getting money to enter
            bjmf.ShowDialog();
            playerMoneyLabel.Text = GlobalData.riskMoney.ToString("C");
            playerBalanceLabel.Text = GlobalData.playerMoney.ToString("C");
            // remaining cards
            cardsRemainingLabel.Text = decks.Count.ToString();
        }
        private static List<string> AddDecks(int count)
        {
            List<string> r = new List<string>();
            while (count-- > 0) { r.AddRange(GlobalData.deck); }

            return r;
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            // new card
            string newCard = CardFromDeck(); playerCards.Add(newCard);
            playerHand += CardValueInt(newCard);                           // counting
            if (CardValueString(newCard) == "A") { playerAces++; }      // aces
            playerHand = IfOver21("player", playerHand);                // if over and ace
            // string
            playerExpandedHand.Text = HandPrint(playerCards);

            // for testing
            playerHandLabel.Text = playerHand.ToString();

            // check if bust, removes hit so player doesnt bust at 21
            if (playerHand > 21) { PlayerLose(1); }
            if (playerHand == 21) { hitButton.Visible = false; }
            // cards remaining
            cardsRemainingLabel.Text = decks.Count.ToString();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            // dealer until 17
            while (dealerHand < 17) {
                string newCard = CardFromDeck(); dealerCards.Add(newCard);
                dealerHand += CardValueInt(newCard);                       // counting
                if (CardValueString(newCard) == "A") { dealerAces++; }  // dealer ace counter
                dealerHand = IfOver21("dealer", dealerHand);            // if over and ace
            }
            dealerExpandedHand.Text = HandPrint(dealerCards);
            // for testing
            dealerHandLabel.Text = dealerHand.ToString();
            // reasons
            if (dealerHand == playerHand) { Push(); }
            else if (dealerHand > 21) { PlayerWin(1); }
            else if (dealerHand > playerHand) { PlayerLose(2); }
            else { PlayerWin(2); }
            // card remaining
            cardsRemainingLabel.Text = decks.Count.ToString();
        }

        private string CardFromDeck()
        {
            int index = rng.Next(0, decks.Count);
            string temp = decks[index];
            decks.RemoveAt(index);
            return temp;
        }

        private void StartGame()
        {
            // getting random cards from deck
            pc1 = CardFromDeck(); pc2 = CardFromDeck();
            dc1 = CardFromDeck(); dc2 = CardFromDeck();
            // adding to list
            playerCards.Add(pc1); playerCards.Add(pc2);
            dealerCards.Add(dc1); dealerCards.Add(dc2);
            // hand value and aces
            playerHand = HandValue(playerCards); playerAces = AceCounter(playerCards);
            dealerHand = HandValue(dealerCards); dealerAces = AceCounter(dealerCards);
            // checking if over 21 on first hand. player and dealer
            playerHand = IfOver21("player", playerHand); dealerHand = IfOver21("dealer", dealerHand);
            // if player is lucky
            if (playerHand == 21) { hitButton.Visible = false; }
            // output
            playerExpandedHand.Text = HandPrint(playerCards);
            dealerExpandedHand.Text = ascii[dc1] + " + ?";

            // for testing
            playerHandLabel.Text = playerHand.ToString();
            dealerHandLabel.Text = dealerHand.ToString();

            // cards remaining
            cardsRemainingLabel.Text = decks.Count.ToString();

            // menu items
            playerHandMenuItem.Visible = true;
            dealerHandMenuItem.Visible = true;
        }

        private string HandPrint(List<string> cards)
        {
            string r = "";
            for (int i = 0; i < cards.Count; i++ ) {
                if (i == 0) { r += ascii[cards[i]]; }
                else { r += " " + ascii[cards[i]]; }
            }
            //foreach (string i in cards) { r += " " + ascii[i]; }
            return r;
        }

        private int CardValueInt(string card)
        {
            string rank = CardValueString(card);
            
            if (rank == "A") { return 11;  }
            else if (rank == "J" || rank == "Q" || rank == "K") { return 10; }
            else { return int.Parse(rank); }
        }

        private string CardValueString(string card)
        {
            if (card.Length == 3) { return card.Substring(0, 2); }
            else { return card.Substring(0, 1); }
        }

        private int HandValue(List<string> hand)
        {
            int total = 0;
            foreach (string card in hand) { total += CardValueInt(card); }
            return total;
        }

        private int AceCounter(List<string> hand)
        {
            int aces = 0;
            foreach (string card in hand) {
                if (CardValueString(card) == "A") { aces++; }
            }
            return aces;
        }

        private int IfOver21(string who, int hand)
        {
            int r = hand;
            if (who == "player" && (hand > 21 && playerAces > 0)) {
                r -= 10;
                playerAces--;
                return r; }
            else if (who == "dealer" && (hand > 21 && dealerAces > 0)) {
                r -= 10;
                dealerAces--;
                return r; }
            else { return r; }
        }

        private void RestartGame()
        {
            // if no money left
            if (GlobalData.riskMoney <= 0)
            {
                MessageBox.Show("You are out of money! \nBetter luck Next Time :(");
                this.Close();
            }
            gameStart = false;
            Screen();
            
            
            // for testing
            playerHandLabel.Visible = false; dealerHandLabel.Visible = false;
            playerHandLabel.Text = ""; dealerHandLabel.Text = "";

            winloseLabel.Text = "";
            // if half cards are remaining of deck ammounts, shuffle
            if (decks.Count < (52 * DECKAMMOUNTS) / 2) { Shuffle(); }
            // cards remaining
            cardsRemainingLabel.Text = decks.Count.ToString();
        }

        private async void Shuffle()
        {
            decks.Clear();
            decks = new List<string>(AddDecks(DECKAMMOUNTS));
            // textbox
            shuffleLabel.Visible = true;
            await waitTimer(3);
            shuffleLabel.Visible = false;
        }

        private void Screen()
        {
            if (gameStart) {
                // phase 1
                oneButton.Visible = false; fiveButton.Visible = false; tenButton.Visible = false; twfivButton.Visible = false; hundButton.Visible = false;
                clearBetButton.Visible = false; betButton.Visible = false;
                // phase 2
                hitButton.Visible = true; standButton.Visible = true;
                playerExpandedHand.Visible = true; dealerExpandedHand.Visible = true;
                // textboxes refresh
                playerExpandedHand.Text = playerExpandedHand.Text; dealerExpandedHand.Text = dealerExpandedHand.Text;
                playerHandLabel.Text = playerHand.ToString(); dealerHandLabel.Text = dealerHand.ToString();
                winloseLabel.Text = winloseLabel.Text; reasonLabel.Text = reasonLabel.Text;
                // menu items
                playerHandMenuItem.Visible = true;
                dealerHandMenuItem.Visible = true; }
            else {
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
                // aces
                playerAces = 0; dealerAces = 0;
                // clearing hands
                playerCards.Clear(); dealerCards.Clear();

                // for testing
                playerHandLabel.Visible = false; dealerHandLabel.Visible = false;
                playerHandLabel.Text = ""; dealerHandLabel.Text = "";
                // menu items
                playerHandMenuItem.Visible = false;
                dealerHandMenuItem.Visible = false;

                winloseLabel.Text = ""; }
        }

        private async Task waitTimer(int secs)
        {
            await Task.Delay(secs * 1000);
        }
    }
}
/* future changes
better gui
split
*/