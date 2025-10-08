using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_Forms_Project
{
    public static class GlobalData
    {
        public static int playerMoney = 1000;       // starting money for player (will be updated)
        public static int riskMoney = 0;            // money when in the different games
        public static List<string> deckValues = new List<string> {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K",
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K",
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K",
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        public static List<string> deckSuits = new List<string> {
                "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s",
                "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c",
                "h", "h", "h", "h", "h", "h", "h", "h", "h", "h", "h", "h", "h",
                "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d"};
        // public static string temp = "";
    }
}
