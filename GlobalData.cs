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
        public static Dictionary<string, string> asciiCards = new Dictionary<string, string> {
            { "As", "🂡" },{ "2s", "🂢" },{ "3s", "🂣" },{ "4s", "🂤" },{ "5s", "🂥" },{ "6s", "🂦" },{ "7s", "🂧" },{ "8s", "🂨" },{ "9s", "🂩" },{ "10s", "🂪" },{ "Js", "🂫" },{ "Qs", "🂭" },{ "Ks", "🂮" },
            { "Ac", "🃑" },{ "2c", "🃒" },{ "3c", "🃓" },{ "4c", "🃔" },{ "5c", "🃕" },{ "6c", "🃖" },{ "7c", "🃗" },{ "8c", "🃘" },{ "9c", "🃙" },{ "10c", "🃚" },{ "Jc", "🃛" },{ "Qc", "🃝" },{ "Kc", "🃞" },
            { "Ah", "🂱" },{ "2h", "🂲" },{ "3h", "🂳" },{ "4h", "🂴" },{ "5h", "🂵" },{ "6h", "🂶" },{ "7h", "🂷" },{ "8h", "🂸" },{ "9h", "🂹" },{ "10h", "🂺" },{ "Jh", "🂻" },{ "Qh", "🂽" },{ "Kh", "🂾" },
            { "Ad", "🃁" },{ "2d", "🃂" },{ "3d", "🃃" },{ "4d", "🃄" },{ "5d", "🃅" },{ "6d", "🃆" },{ "7d", "🃇" },{ "8d", "🃈" },{ "9d", "🃉" },{ "10d", "🃊" },{ "Jd", "🃋" },{ "Qd", "🃍" },{ "Kd", "🃎" } };  
        // public static string temp = "";
    }
}
