using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class PokerForm
    {
        int currPlaying, phase, dealerPosition, turnOrder, DECKSAMMOUNT = 4;
        List<string> decks, plyC, opp1C, opp2C, opp3C, opp4C;
        Dictionary<string, string> special = GlobalData.specialCards;
        List<List<string>> allOpponentsC = new List<List<string>>(), opponentsC = new List<List<string>>();
        List<PkOppForm> allOpponents, opponents;
        PkOppForm ply, opp1, opp2, opp3, opp4;
        Random rng = new Random();
        MainForm mainForm; PkButtonsForm b; PkFloppinator fl;

        public PokerForm(MainForm main)
        {
            mainForm = main;
            decks = new List<string>(GlobalData.AddDecks(count: DECKSAMMOUNT));
            //pcf = new PkPlayerCardForm();
            b = new PkButtonsForm(this); fl = new PkFloppinator();
            ply = new PkOppForm(); opp1 = new PkOppForm(); opp2 = new PkOppForm(); opp3 = new PkOppForm(); opp4 = new PkOppForm();
            plyC = new List<string>(); opp1C = new List<string>(); opp2C = new List<string>(); opp3C = new List<string>(); opp4C = new List<string>();
            allOpponents = new List<PkOppForm> { ply, opp1, opp2, opp3, opp4 };
            allOpponentsC.Add(plyC); allOpponentsC.Add(opp1C); allOpponentsC.Add(opp2C); allOpponentsC.Add(opp3C); allOpponentsC.Add(opp4C); 

            FirstStart();

            Deal();

            GameStart();
        }

        public void updatelabel()
        {
            ply.UpdateChipLabel(); opp1.UpdateChipLabel(); opp2.UpdateChipLabel(); opp3.UpdateChipLabel(); opp4.UpdateChipLabel();
        }

        private void GameStart()
        {
            InitialBets();
                        
            //Turns();

            //flop();
        }

        private void InitialBets()
        {
            for (int i = 0; i < currPlaying; i++) {
                if (opponents[i].GetSmall()) { opponents[i].SetBetMoneyLabel(5); }
                else if (opponents[i].GetBig()) { opponents[i].SetBetMoneyLabel(10); }
                else { opponents[i].SetBetMoneyLabel(0); } }
        }

        private void Deal()
        {
            for (int i = 0; i < currPlaying; i++)
            {
                string card1 = GlobalData.CardFromDeck(rng, decks), card2 = GlobalData.CardFromDeck(rng, decks);
                opponentsC[i].Add(card1); allOpponentsC[i].Add(card2);
                int value = GlobalData.HandValueFromCards(opponentsC[i]);
                if (opponents[i].GetIsPlayer()) { 
                    opponents[i].SetExpandedHand(GlobalData.HandPrint(allOpponentsC[i])); }
                    //opponents[i].SetHandValueLabel(value.ToString()); }
                    //opponents[i].SetHandValueLabel(GlobalData.TranslateCard(card1) + " " + GlobalData.TranslateCard(card2)); }
                else {
                    opponents[i].SetExpandedHand(special["back"] + " " + special["back"]); }
                    //opponents[i].SetHandValueLabel("?"); }
                    // FOR TESTING
                    //opponents[i].SetExpandedHand(GlobalData.HandPrint(allOpponentsC[i]));
                    //opponents[i].SetHandValueLabel(value.ToString()); }
                opponents[i].Show();
            }
        }

        private void FirstStart()
        {
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
                opponentsC.Add(allOpponentsC[i]);
                if (i == 0) { opponents[i].SetPlayer(true); }
                opponents[i].FormStartingPosition(xpositions[i], ypositions[i]);
                opponents[i].Text = names[i];
            }

            // getting dealer, small, big chips
            dealerPosition = rng.Next(0, currPlaying-1);
            turnOrder = dealerPosition;

            b.Show();
            ChipsRotator();
            //PhaseRotator();
            updatelabel();
        }

        private void ChipsRotator()
        {
            int temp = dealerPosition; opponents[temp].SetDealer(true);
            if (temp - 1 < 0) { temp = currPlaying - 1; opponents[temp].SetDealer(false); temp = 0; }
            else { opponents[temp - 1].SetDealer(false); }

            temp++;
            if (temp > currPlaying-1) { temp = 0; } opponents[temp].SetSmall(true); dealerPosition = temp;
            if (temp - 1 < 0) { temp = currPlaying - 1; opponents[temp].SetSmall(false); temp = 0; }
            else { opponents[temp - 1].SetSmall(false); }

            temp++;
            if (temp > currPlaying-1) { temp = 0; } opponents[temp].SetBig(true);
            if (temp - 1 < 0) { temp = currPlaying - 1; opponents[temp].SetBig(false); temp = 0; }
            else { opponents[temp - 1].SetBig(false); }

            if (temp + 1 > currPlaying - 1) { turnOrder = 0; }
            else { turnOrder = temp + 1; }
            Console.WriteLine(turnOrder);
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