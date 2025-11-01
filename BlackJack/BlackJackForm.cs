using System;
using System.Collections.Generic;
using System.Linq;
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
        MainForm mainForm;
        // experimental
        bool experimental = false;
        PlayerCardForm pcf; DealerCardForm dcf; Buttons b; Information info;
        public BlackJackForm(MainForm main)
        {
            this.MaximizeBox = false;
            InitializeComponent();
            MoneyForm mf = new MoneyForm(); mf.ShowDialog();
            decks = new List<string>(AddDecks(DECKAMMOUNTS));
            mainForm = main;

            pcf = new PlayerCardForm(); dcf = new DealerCardForm(); b = new Buttons(this); info = new Information();

            Screen();

            foreach (Form openForm in Application.OpenForms.Cast<Form>().ToList()) { if (openForm is MainForm) { openForm.Hide(); } }
        }
        public void Hit()
        {
            playerCards.Add(CardFromDeck());
            playerHand = HandValueFromCards(playerCards);

            Screen();

            // check if bust, removes hit so player doesnt bust at 21
            if (playerHand > 21) { PlayerLose(1); }
        }

        public void Stand()
        {
            // dealer until 17
            while (dealerHand < 17) {
                dealerCards.Add(CardFromDeck());
                dealerHand = HandValueFromCards(dealerCards); }
            Screen();

            dealerExpandedHand.Text = HandPrint(dealerCards);
            dealerHandLabel.Text = dealerHand.ToString();

            // experimental
            if (experimental) { dcf.setDealerEHLabel(HandPrint(dealerCards)); }

            // reasons
            if (dealerHand == playerHand) { Push(); }
            else if (dealerHand > 21) { PlayerWin(1); }
            else if (dealerHand > playerHand) { PlayerLose(2); }
            else { PlayerWin(2); }
        }

        private static List<string> AddDecks(int count)
        {
            List<string> r = new List<string>();
            while (count-- > 0) { r.AddRange(GlobalData.deck); }
            return r;
        }

        private void experimentalButton_Click(object sender, EventArgs e)
        {
            experimental = true; b.Show(); info.Show(); this.Hide();
            Screen();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            Hit();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            Stand();
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
            // experimental
            if (experimental) { dcf.setDealerEHLabel(ascii[dc1] + " + ?"); }
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

        private void BlackJackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalData.setPlayerMoney(GlobalData.getPlayerMoney() + GlobalData.getRiskMoney());
            mainForm.UpdateLabels();
            mainForm.Show();
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
                MessageBox.Show("You are out of money! \nBetter luck Next Time :(", "No More Money!");
                this.Close(); }
            gameStart = false;
            // experimental
            b.setStarted(false);
            b.smallScreen();
            Screen();
            // if half cards are remaining of deck ammounts, shuffle
            if (decks.Count < (52 * DECKAMMOUNTS) / 2) { Shuffle(); }
        }
        public void ReturnFromExperimental()
        {
            if (pcf != null && !pcf.IsDisposed) pcf.Close();
            if (dcf != null && !dcf.IsDisposed) dcf.Close();
            if (info != null && !info.IsDisposed) info.Close();

            // show the main blackjack form
            this.Hide();
            mainForm.Show();
            this.Close();
        }

        private async void Shuffle()
        {
            decks.Clear();
            decks = new List<string>(AddDecks(DECKAMMOUNTS));
            // textbox
            shuffleLabel.Visible = true;
            if (experimental) { info.SetShuffleVisibility(true); }
            await waitTimer(3);
            shuffleLabel.Visible = false;
            if (experimental) { info.SetShuffleVisibility(false); }
        }

        private async Task waitTimer(int secs)
        {
            await Task.Delay(secs * 1000);
        }
    }
}