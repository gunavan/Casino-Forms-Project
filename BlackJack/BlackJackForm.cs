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
        int bet = 0, playerHand = 0, dealerHand = 0, DECKAMMOUNTS = 4;
        string pc1, pc2, dc1, dc2;
        bool gameStart = false, experimental = false;
        // hands and decks
        List<string> playerCards = new List<string>(), dealerCards = new List<string>(), decks;
        // for ascii cards
        Dictionary<string, string> ascii = new Dictionary<string, string>(GlobalData.asciiCards), special = new Dictionary<string, string>(GlobalData.specialCards);
        private Random rng = new Random();
        MainForm mainForm;
        // experimental forms
        BJPlayerCardForm pcf; BJDealerCardForm dcf; BJButtons b; BJInformation info;
        public BlackJackForm(MainForm main)
        {
            this.MaximizeBox = false;
            InitializeComponent();
            MoneyForm mf = new MoneyForm(); mf.ShowDialog();
            decks = new List<string>(GlobalData.AddDecks(count: DECKAMMOUNTS));
            mainForm = main;

            pcf = new BJPlayerCardForm(); dcf = new BJDealerCardForm(); b = new BJButtons(this); info = new BJInformation();

            Screen();
        }

        // buttons
        private void experimentalButton_Click(object sender, EventArgs e) { experimental = true; b.Show(); info.Show(); this.Hide(); Screen(); }
        private void hitButton_Click(object sender, EventArgs e) { Hit(); }
        private void standButton_Click(object sender, EventArgs e) { Stand(); }

        public void Hit()
        {
            playerCards.Add(GlobalData.CardFromDeck(rng, decks));
            playerHand = GlobalData.HandValueFromCards(playerCards);

            Screen();

            // check if bust, removes hit so player doesnt bust at 21
            if (playerHand > 21) { PlayerLose(1); }
        }

        public void Stand()
        {
            // dealer until 17
            while (dealerHand < 17) {
                dealerCards.Add(GlobalData.CardFromDeck(rng, decks));
                dealerHand = GlobalData.HandValueFromCards(dealerCards); }
            Screen();
            dealerExpandedHand.Text = GlobalData.HandPrint(dealerCards);
            dealerHandLabel.Text = dealerHand.ToString();

            // experimental
            if (experimental) { 
                dcf.SetDealerEHLabel(GlobalData.HandPrint(dealerCards));
                dcf.SetDealerHandLabel(dealerHand.ToString()); }

            // reasons
            if (dealerHand == playerHand) { Push(); }
            else if (dealerHand > 21) { PlayerWin(1); }
            else if (dealerHand > playerHand) { PlayerLose(2); }
            else { PlayerWin(2); }
        }

        private void StartGame()
        {
            pc1 = GlobalData.CardFromDeck(rng, decks); pc2 = GlobalData.CardFromDeck(rng, decks);
            dc1 = GlobalData.CardFromDeck(rng, decks); dc2 = GlobalData.CardFromDeck(rng, decks);
            
            playerCards.Add(pc1); playerCards.Add(pc2);
            dealerCards.Add(dc1); dealerCards.Add(dc2);
            
            playerHand = GlobalData.HandValueFromCards(playerCards);
            dealerHand = GlobalData.HandValueFromCards(dealerCards);

            Screen();
            
            // dealer mystery output
            dealerExpandedHand.Text = ascii[dc1] + " " + special["back"];
            dealerHandLabel.Text = GlobalData.GetCardValueInt(dc1).ToString() + " + ?";
            // experimental
            if (experimental) { 
                dcf.SetDealerEHLabel(ascii[dc1] + " " + special["back"]);
                dcf.SetDealerHandLabel(GlobalData.GetCardValueString(dc1).ToString() + " + ?"); }
        }

        private void BlackJackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalData.setPlayerMoney(GlobalData.getPlayerMoney() + GlobalData.getRiskMoney());
            mainForm.UpdateLabels();
            mainForm.Show();
        }

        private void RestartGame()
        {
            // if no money left
            if (GlobalData.riskMoney <= 0) {
                MessageBox.Show("You are out of money! \nBetter luck Next Time :(", "No More Money!");
                ReturnToMain();
                b.Close(); }
            gameStart = false;
            // experimental
            b.SetStarted(false);
            b.SmallScreen();
            Screen();
            // if half cards are remaining of deck ammounts, shuffle
            if (decks.Count < (52 * DECKAMMOUNTS) / 2) { Shuffle(); }
        }
        public void ReturnToMain()
        {
            if (pcf != null && !pcf.IsDisposed) pcf.Close();
            if (dcf != null && !dcf.IsDisposed) dcf.Close();
            if (info != null && !info.IsDisposed) info.Close();

            // show the main blackjack form
            mainForm.Show();
            this.Close();
        }

        private async void Shuffle()
        {
            decks.Clear();
            decks = new List<string>(GlobalData.AddDecks(DECKAMMOUNTS));
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