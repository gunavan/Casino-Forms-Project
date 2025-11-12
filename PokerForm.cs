using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class PokerForm
    {
        int currPlaying, phase, dealerPosition;
        int DECKSAMMOUNT = 4;
        List<string> decks, playerCards = new List<string>();
        List<PkOppForm> allOpponents, opponents;
        PkOppForm ply, opp1, opp2, opp3, opp4;
        private Random rng = new Random();
        MainForm mainForm; PkButtonsForm b; PkFloppinator fl;
        public PokerForm(MainForm main)
        {
            mainForm = main;
            decks = new List<string>(GlobalData.AddDecks(count: DECKSAMMOUNT));
            //pcf = new PkPlayerCardForm();
            b = new PkButtonsForm(this); fl = new PkFloppinator();
            ply = new PkOppForm();
            opp1 = new PkOppForm(); opp2 = new PkOppForm(); opp3 = new PkOppForm(); opp4 = new PkOppForm();

            FirstStart();

            //Deal();
        }

        // NEEDS TO BE ALL THE SAME FORM TO HAVE CONSISTENT OBJECT WITH
        // GENERIC METHODS WITH GETTERS AND SETTERS

        private void Deal()
        {
            
        }

        private void FirstStart()
        {
            allOpponents = new List<PkOppForm> { ply, opp1, opp2, opp3, opp4 };
            opponents = new List<PkOppForm>();
            // positioning
            int screenWidth = GlobalData.getScreenWidth(), screenHeight = GlobalData.getScreenHeight(), formWidth, formHeight; formWidth = opp1.GetWidth(); formHeight = opp2.GetHeight();
            int[] xpositions = { (screenWidth - formWidth) / 2, 10, (screenWidth - formWidth) / 4, (screenWidth - formWidth) * 3 / 4, (screenWidth - formWidth)};
            int[] ypositions = { screenHeight - formHeight, (screenHeight - formHeight) / 2, 10, 10, (screenHeight - formHeight) / 2};
            // naming
            string[] names = { "You!", "Matthew", "Sarah", "Adam", "Mary" };
            // money
            MoneyForm mf = new MoneyForm(); mf.ShowDialog();
            // opponents
                // phase #0
            PkOpponentsSelect pkos = new PkOpponentsSelect();
            pkos.ShowDialog(); currPlaying = pkos.GetOpponents() + 1;
            
            // adding player and num of opponents
            for (int i = 0; i < currPlaying; i++) {
                opponents.Add(allOpponents[i]);
                opponents[i].FormStartingPosition(xpositions[i], ypositions[i]);
                opponents[i].Text = names[i];
                opponents[i].SetDealer(false); opponents[i].SetSmall(false); opponents[i].SetBig(false);
                opponents[i].Show(); }

            // getting dealer, small, big chips
            // if 2 check what should happen
            dealerPosition = rng.Next(0, currPlaying-1);
            ChipsRotator();
            
            b.Show();
            PhaseRotator();
        }

        private void ChipsRotator()
        {
            int temp = dealerPosition; opponents[temp].SetDealer(true);
            temp++; if (temp > currPlaying-1) { temp = 0; } opponents[temp].SetSmall(true);
            temp++; if (temp > currPlaying-1) { temp = 0; } opponents[temp].SetBig(true);
        }

        private void PhaseRotator()
        {
            if (phase == 5) { phase = 1; }
            else { phase++; }
        }

        public void ReturnToMain()
        {
            
            opp1.Close(); opp2.Close(); opp3.Close(); opp4.Close();
            //pcf.Close();
            ply.Close();
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