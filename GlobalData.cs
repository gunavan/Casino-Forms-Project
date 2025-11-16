using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public static class GlobalData
    {
        public static int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        public static int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        public static int playerMoney = 1000;       // starting money for player (will be updated)
        public static int riskMoney = 0;            // money when in the different games
        public static List<string> deck = new List<string> {
                "As", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "10s", "Js", "Qs", "Ks",
                "Ac", "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "10c", "Jc", "Qc", "Kc",
                "Ah", "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "10h", "Jh", "Qh", "Kh",
                "Ad", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "10d", "Jd", "Qd", "Kd"};
        public static Dictionary<string, string> asciiCards = new Dictionary<string, string> {
            { "As", "🂡" },{ "2s", "🂢" },{ "3s", "🂣" },{ "4s", "🂤" },{ "5s", "🂥" },{ "6s", "🂦" },{ "7s", "🂧" },{ "8s", "🂨" },{ "9s", "🂩" },{ "10s", "🂪" },{ "Js", "🂫" },{ "Qs", "🂭" },{ "Ks", "🂮" },
            { "Ac", "🃑" },{ "2c", "🃒" },{ "3c", "🃓" },{ "4c", "🃔" },{ "5c", "🃕" },{ "6c", "🃖" },{ "7c", "🃗" },{ "8c", "🃘" },{ "9c", "🃙" },{ "10c", "🃚" },{ "Jc", "🃛" },{ "Qc", "🃝" },{ "Kc", "🃞" },
            { "Ah", "🂱" },{ "2h", "🂲" },{ "3h", "🂳" },{ "4h", "🂴" },{ "5h", "🂵" },{ "6h", "🂶" },{ "7h", "🂷" },{ "8h", "🂸" },{ "9h", "🂹" },{ "10h", "🂺" },{ "Jh", "🂻" },{ "Qh", "🂽" },{ "Kh", "🂾" },
            { "Ad", "🃁" },{ "2d", "🃂" },{ "3d", "🃃" },{ "4d", "🃄" },{ "5d", "🃅" },{ "6d", "🃆" },{ "7d", "🃇" },{ "8d", "🃈" },{ "9d", "🃉" },{ "10d", "🃊" },{ "Jd", "🃋" },{ "Qd", "🃍" },{ "Kd", "🃎" } };
        public static Dictionary<string, string> specialCards = new Dictionary<string, string> {
            { "back", "🂠" }, { "jR", "🂿" }, { "jB", "🃏︎" }, { "jW", "🃟" }, { "s", "♠" }, { "c", "♣" }, { "h", "♥" }, { "d", "♦" } };

        // screen
        public static int getScreenWidth() { return screenWidth; }

        public static int getScreenHeight() { return screenHeight; }

        // player money
        public static int getPlayerMoney() { return playerMoney; }

        public static void setPlayerMoney(int amount) { playerMoney = amount; }

        // risk money
        public static int getRiskMoney() { return riskMoney; }

        public static void setRiskMoney(int amount) { riskMoney = amount; }

        // hand value from list of cards
        public static int HandValueFromCards(List<string> hand)
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

        // translator

        public static string TranslateCard(string card)
        {
            string suit = card.Substring(card.Length - 1);
            string r = GetCardValueString(card);
            
            return r + specialCards[suit];
        }

        // card value STRING
        public static string GetCardValueString(string card)
        {
            if (card.Length == 3) { return card.Substring(0, 2); }
            else { return card.Substring(0, 1); }
        }

        // card value INT
        public static int GetCardValueInt(string card)
        {
            string rank = GetCardValueString(card);

            if (rank == "A") { return 11; }
            else if (rank == "J" || rank == "Q" || rank == "K") { return 10; }
            else { return int.Parse(rank); }
        }
        // hand print
        public static string HandPrint(List<string> cards)
        {
            string r = "";
            for (int i = 0; i < cards.Count; i++) {
                if (i == 0) { r = asciiCards[cards[i]]; }
                else { r += " " + asciiCards[cards[i]]; } }
            return r;
        }

        // adding decks
        public static List<string> AddDecks(int count)
        {
            List<string> r = new List<string>();
            while (count-- > 0) { r.AddRange(GlobalData.deck); }
            return r;
        }

        // card from deck
        public static string CardFromDeck(Random rng, List<string> decks)
        {
            int index = rng.Next(0, decks.Count());
            string temp = decks[index];
            decks.RemoveAt(index);
            return temp;
        }
    } 
}
