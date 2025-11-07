using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class PokerForm
    {
        int numOpponents, phase, dealerPosition;
        int DECKSAMMOUNT = 4;
        List<string> decks, playerCards = new List<string>();
        List<PkOppForm> allOpponents, opponents;
        //LinkedList<PkPlayOpp> things = new LinkedList<PkPlayOpp>(); 
        
        MainForm mainForm;
        // creating forms
        PkPlayerCardForm pcf; PkButtonsForm b;
        PkOppForm opp1; PkOppForm opp2; PkOppForm opp3; PkOppForm opp4;
        PkPlayOpp p1, p2, p3, p4, p5;
        LinkedList<PkPlayOpp> everyone = new LinkedList<PkPlayOpp>();
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
            int screenWidth = GlobalData.getScreenWidth(), screenHeight = GlobalData.getScreenHeight(), formWidth, formHeight; formWidth = opp1.GetWidth(); formHeight = opp2.GetHeight();
            int[] xpositions = { (screenWidth - formWidth) / 2, 10, (screenWidth - formWidth) / 4, (screenWidth - formWidth) * 3 / 4, (screenWidth - formWidth) };
            int[] ypositions = { screenHeight - formHeight, (screenHeight - formHeight) / 2, 10, 10, (screenHeight - formHeight) / 2 };
            // naming
            string[] names = { "You!", "Matthew", "Sarah", "Adam", "Mary" };
            // money
            MoneyForm mf = new MoneyForm(); mf.ShowDialog();
            // opponents
                // phase #0
            PkOpponentsSelect pkos = new PkOpponentsSelect();
            pkos.ShowDialog(); numOpponents = pkos.GetOpponents();

            // adding everyone
            pcf.FormStartingPosition(xpositions[0], ypositions[0]);
            everyone.AddLast(new PkPlayOpp(pcf, names[0], true, false, false, false));
            
            for (int i = 1; i <= numOpponents; i++) {
                allOpponents[i-1].FormStartingPosition(xpositions[i], ypositions[i]);
                allOpponents[i-1].Text = names[i];
                everyone.AddLast(new PkPlayOpp(allOpponents[i-1], names[i], false, false, false, false));
            }

            // dealer position
            Random rng = new Random();
            dealerPosition = rng.Next(0, everyone.Count);

            ChipsRotator();
            
            // initial bets

            // show cards
            foreach (var p in everyone)
            {
                p.FormType.Show();
            }
            b.Show();

            phase = 1;
        }

        private void ChipsRotator()
        {
            LinkedListNode<PkPlayOpp> dealer = everyone.First;
            dealer.Value.DealerC = true;

            LinkedListNode<PkPlayOpp> small = dealer.Next ?? everyone.First;
            small.Value.SmallC = true;

            LinkedListNode<PkPlayOpp> big = small.Next ?? everyone.First;
            big.Value.BigC = true;
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