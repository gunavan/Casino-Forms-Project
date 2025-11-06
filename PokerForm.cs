using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class PokerForm
    {
        int numOpponents, phase, dealerPosition;
        int DECKSAMMOUNT = 4;
        List<string> decks, playerCards = new List<string>();
        List<PkOppForm> allOpponents, opponents;
        LinkedList<Form> things = new LinkedList<Form>(); 
        MainForm mainForm;
        // creating forms
        PkPlayerCardForm pcf; PkButtonsForm b; PkOppForm opp1; PkOppForm opp2; PkOppForm opp3; PkOppForm opp4;
        PkFloppinator fl;
        public PokerForm(MainForm main)
        {
            mainForm = main;
            decks = new List<string>(GlobalData.AddDecks(count: DECKSAMMOUNT));

            FirstStart();
        }

        private void FirstStart()
        {
            pcf = new PkPlayerCardForm(); b = new PkButtonsForm(this); fl = new PkFloppinator();
            opp1 = new PkOppForm(); opp2 = new PkOppForm(); opp3 = new PkOppForm(); opp4 = new PkOppForm();
            allOpponents = new List<PkOppForm> { opp1, opp2, opp3, opp4 };
            // positioning
            int screenWidth = GlobalData.getScreenWidth(), screenHeight = GlobalData.getScreenHeight(), formWidth, formHeight;
            formWidth = opp1.GetWidth(); formHeight = opp2.GetHeight();
            int[] xpositions = { 10, (screenWidth - formWidth) / 4, (screenWidth - formWidth) * 3 / 4, (screenWidth - formWidth) };
            int[] ypositions = { (screenHeight - formHeight) / 2, 10, 10, (screenHeight - formHeight) / 2 };
            // naming
            string[] names = { "Matthew", "Sarah", "Adam", "Mary" };
            // money
            MoneyForm mf = new MoneyForm(); mf.ShowDialog();
            // opponents
                // phase #0
            PkOpponentsSelect pkos = new PkOpponentsSelect();
            pkos.ShowDialog(); numOpponents = pkos.GetOpponents();
            allOpponents = allOpponents.Take(numOpponents).ToList();
            things.AddFirst(pcf);
            for (int i = 0; i < allOpponents.Count(); i++) {
                allOpponents[i].SetOpponentName(names[i]);
                allOpponents[i].FormStartingPosition(xpositions[i], ypositions[i]);
                allOpponents[i].Show();
                things.AddLast(allOpponents[i]); }
            // dealer position
            Random rng = new Random();
            dealerPosition = rng.Next(0, opponents.Count());
            //things.ElementAt(dealerPosition).SetDealer();
            // trying to find location at dealer position to set true and .Next() as big and small
            // need a way to categorize and organize player and opponents
            // initial bets

            // show cards
            pcf.Show();
            b.Show();

            phase = 1;
        }

        private void PhaseRotator()
        {
            if (phase == 5) { phase = 1; }
            else { phase++; }
        }

        public void ReturnToMain()
        {
            
            opp1.Close(); opp2.Close(); opp3.Close(); opp4.Close();
            pcf.Close();
            fl.Close();
            mainForm.Show();
            
        }

        private void PkScreen()
        {
            // phase #1
        }
    }
}
// forms works and closing too
// missing all phases