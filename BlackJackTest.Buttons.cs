using System;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public partial class Buttons : Form
    {
        private BlackJackForm blackJackForm;
        bool started = false;
        public Buttons(BlackJackForm form)
        {
            InitializeComponent();
            this.blackJackForm = form;

            this.StartPosition = FormStartPosition.Manual;
            PositionForm();
        }

        private void PositionForm()
        {
            // screen w and h
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width; int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            // this forms w and h
            int formWidth = this.Width; int formHeight = this.Height;
            // Calculate the position
            int x = (screenWidth - formWidth); // Center horizontally
            int y = (screenHeight - formHeight) / 2;
            this.Location = new System.Drawing.Point(x, y);
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            blackJackForm.Hit();
        }
        private void standButton_Click(object sender, EventArgs e)
        {
            blackJackForm.Stand();
        }

        public bool getStarted() { return started; }

        public void setStarted(bool r) { started = r; }

        private void oneButton_Click(object sender, EventArgs e)
        {
            blackJackForm.setBet(blackJackForm.getBet() + 1);
            currBetLabel.Text = blackJackForm.getBet().ToString("C");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            blackJackForm.setBet(blackJackForm.getBet() + 5);
            currBetLabel.Text = blackJackForm.getBet().ToString("C");
        }

        private void tenButton_Click(object sender, EventArgs e)
        {
            blackJackForm.setBet(blackJackForm.getBet() + 10);
            currBetLabel.Text = blackJackForm.getBet().ToString("C");
        }

        private void twfivButton_Click(object sender, EventArgs e)
        {
            blackJackForm.setBet(blackJackForm.getBet() + 25);
            currBetLabel.Text = blackJackForm.getBet().ToString("C");
        }

        private void hundButton_Click(object sender, EventArgs e)
        {
            blackJackForm.setBet(blackJackForm.getBet() + 100);
            currBetLabel.Text = blackJackForm.getBet().ToString("C");
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            blackJackForm.PlaceBet();
            started = true;
            smallScreen();
        }

        public void smallScreen()
        {
            if (started)
            {
                oneButton.Visible = false; fiveButton.Visible = false; tenButton.Visible = false; twfivButton.Visible = false; hundButton.Visible = false;
                betButton.Visible = false; clearBetButton.Visible = false;
                hitButton.Visible = true; standButton.Visible = true;
            }
            else
            {
                oneButton.Visible = true; fiveButton.Visible = true; tenButton.Visible = true; twfivButton.Visible = true; hundButton.Visible = true;
                betButton.Visible = true; clearBetButton.Visible = true;
                hitButton.Visible = false; standButton.Visible = false;
            }
        }
    }
}
// HIT AND STAND STILL VISIBLE MID GAME OR AFTER GAME