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
    public partial class BJInformation : Form
    {
        public BJInformation()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.Manual;
            PositionForm();
        }

        public void SetWinLose(string result) { winloseLabel.Text = result; }

        public void SetWinLoseVisibility(bool visible) { winloseLabel.Visible = visible; }

        public void SetReason(string reason) { reasonLabel.Text = reason; }

        public void SetReasonVisibility(bool visible) { reasonLabel.Visible = visible; }

        public void SetShuffleVisibility(bool visible) { shuffleLabel.Visible = visible; }

        public void SetBlackJackMoney(string money) { playerMoneyLabel.Text = money; }

        public void SetCardsRemaining(string cardsLeft) { cardsRemainingLabel.Text = cardsLeft; }

        public void SetBalance(string money) { playerBalanceLabel.Text = money; }

        private void PositionForm()
        {
            // screen w and h
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width; int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            // this forms w and h
            int formWidth = this.Width; int formHeight = this.Height;
            // Calculate the position
            int x = 10;
            int y = (screenHeight - formHeight) / 2;

            this.Location = new System.Drawing.Point(x, y);
        }
    }
}
