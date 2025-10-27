using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class BlackJackForm : Form
    {
        // variables
        int bet = 0, playerHand = 0, dealerHand = 0, DECKAMMOUNTS = 4; //int playerAces = 0, dealerAces = 0;
        string pc1, pc2, dc1, dc2;
        bool gameStart = false;
        // deck from main
        List<string> playerCards = new List<string>(); List<string> dealerCards = new List<string>();
        List<string> decks = new List<string>();
        Dictionary<string, string> ascii = new Dictionary<string, string>(GlobalData.asciiCards);
        private Random rng = new Random();

        public BlackJackForm()
        {
            InitializeComponent();
            BlackjackMoneyForm bjmf = new BlackjackMoneyForm();
            decks = new List<string>(AddDecks(DECKAMMOUNTS));
            bjmf.ShowDialog();
            playerMoneyLabel.Text = GlobalData.riskMoney.ToString("C"); playerBalanceLabel.Text = GlobalData.playerMoney.ToString("C");
            Screen();
        }
        private static List<string> AddDecks(int count)
        {
            List<string> r = new List<string>();
            while (count-- > 0) { r.AddRange(GlobalData.deck); }
            return r;
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            playerCards.Add(CardFromDeck());
            playerHand = HandValueFromCards(playerCards);

            Screen();

            // check if bust, removes hit so player doesnt bust at 21
            if (playerHand > 21) { PlayerLose(1); }
            if (playerHand == 21) { hitButton.Visible = false; }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            // dealer until 17
            while (dealerHand < 17) {
                dealerCards.Add(CardFromDeck());
                dealerHand = HandValueFromCards(dealerCards);
            }
            Screen();

            dealerExpandedHand.Text = HandPrint(dealerCards);
            dealerHandLabel.Text = dealerHand.ToString();

            // reasons
            if (dealerHand == playerHand) { Push(); }
            else if (dealerHand > 21) { PlayerWin(1); }
            else if (dealerHand > playerHand) { PlayerLose(2); }
            else { PlayerWin(2); }
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
            pc1 = CardFromDeck(); pc2 = CardFromDeck();
            dc1 = CardFromDeck(); dc2 = CardFromDeck();
            
            playerCards.Add(pc1); playerCards.Add(pc2);
            dealerCards.Add(dc1); dealerCards.Add(dc2);
            
            playerHand = HandValueFromCards(playerCards);
            dealerHand = HandValueFromCards(dealerCards);

            Screen();
            
            // dealer mystery output
            dealerExpandedHand.Text = ascii[dc1] + " + ?";
            dealerHandLabel.Text = GetCardValueInt(dc1).ToString() + " + ?";
        }

        private string HandPrint(List<string> cards)
        {
            string r = "";
            for (int i = 0; i < cards.Count; i++ ) {
                if (i == 0) { r = ascii[cards[i]]; }
                else { r += " " + ascii[cards[i]]; } }
            return r;
        }

        private int GetCardValueInt(string card)
        {
            string rank = GetCardValueString(card);
            
            if (rank == "A") { return 11;  }
            else if (rank == "J" || rank == "Q" || rank == "K") { return 10; }
            else { return int.Parse(rank); }
        }

        private string GetCardValueString(string card)
        {
            if (card.Length == 3) { return card.Substring(0, 2); }
            else { return card.Substring(0, 1); }
        }

        private int HandValueFromCards(List<string> hand)
        {
            int handValue = 0, aces = 0;
            foreach (string card in hand) {
                handValue += GetCardValueInt(card);
                if (GetCardValueString(card) == "A") { aces++; } }
            while (handValue > 21 && aces > 0) { 
                handValue -= 10;
                aces--; }
            return handValue;
        }

        private void RestartGame()
        {
            // if no money left
            if (GlobalData.riskMoney <= 0) {
                MessageBox.Show("You are out of money! \nBetter luck Next Time :(");
                this.Close(); }
            gameStart = false;
            Screen();
            // if half cards are remaining of deck ammounts, shuffle
            if (decks.Count < (52 * DECKAMMOUNTS) / 2) { Shuffle(); }
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

        private async Task waitTimer(int secs)
        {
            await Task.Delay(secs * 1000);
        }
    }
}