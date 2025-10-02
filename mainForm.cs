using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class mainForm : Form
    {
        public static class GlobalData
        {
            public static int playerMoney = 1000;       // starting money for player (will be updated)
            public static int riskMoney = 0;            // money when in the different games
            public static List<string> deckValues = new List<string> {
                "a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k",
                "a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k",
                "a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k",
                "a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k"};
            public static List<string> deckSuits = new List<string> {
                "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s",
                "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c",
                "h", "h", "h", "h", "h", "h", "h", "h", "h", "h", "h", "h", "h",
                "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d", "d"};
        }
        public mainForm()
        {
            InitializeComponent();
            playerMoneyLabel.Text = GlobalData.playerMoney.ToString("C");
        }

        private void blackjackButton_Click(object sender, EventArgs e)
        {
            blackjackForm bjf = new blackjackForm();
            bjf.ShowDialog();
            playerMoneyLabel.Text = GlobalData.playerMoney.ToString("C");
        }
    }
}
