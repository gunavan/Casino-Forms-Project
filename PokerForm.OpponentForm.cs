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
    public partial class PkOppForm : Form
    {
        bool dealer = false, small = false, big = false, player = false;
        int bet = 0;
        public PkOppForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.Manual;
        }

        public void UpdateChipLabel()
        {
            if (dealer) { chipLabel.Text = "D"; return; }
            if (small) { chipLabel.Text = "S"; return; }
            if (big) { chipLabel.Text = "B"; return; }
            if (!dealer || !small || !big) { chipLabel.Text = ""; return; }
        }

        public void ResetBet() { bet = 0; }

        public int GetBetMoneyLabel() { return bet; }

        public bool GetIsPlayer() { return player;  }

        public int GetHandValue() { return int.Parse(handValueLabel.Text); }

        public string GetExpandedHand() { return printedHandLabel.Text; }

        public bool GetDealer() { return dealer; }

        public bool GetSmall() { return small; }

        public bool GetBig() { return big; }

        public void SetBetMoneyLabel(int i) { bet = i; currBetLabel.Text = bet.ToString("C"); }

        public void SetPlayer(bool v) { player = v; }

        public void SetHandValueLabel(string s) { handValueLabel.Text = s; }

        public void SetExpandedHand(string s) { printedHandLabel.Text = s; }

        public void SetDealer(bool b) { dealer = b; }

        public void SetSmall(bool b) { small = b; }

        public void SetBig(bool b) { big = b; }

        public int GetWidth() { return this.Width; }

        public int GetHeight() { return this.Height; }

        public void FormStartingPosition(int x, int y) { this.Location = new System.Drawing.Point(x, y); }

        public void SetName(string name) { this.Text = name; }
    }
}
