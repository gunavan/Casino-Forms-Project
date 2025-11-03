using System;
using System.Linq;
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

        private void Buttons_FormClosed(object sender, FormClosedEventArgs e)
        {
            blackJackForm.ReturnFromExperimental();
        }

        private void PositionForm()
        {
            // screen w and h
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width; int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            // this forms w and h
            int formWidth = this.Width; int formHeight = this.Height;
            // Calculate the position
            int x = (screenWidth - formWidth) - 10; // Center horizontally
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

        public bool GetStarted() { return started; }

        public void SetStarted(bool r) { started = r; }

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
            SmallScreen();
        }

        public void SmallScreen()
        {
            if (started)
            {
                oneButton.Visible = false; fiveButton.Visible = false; tenButton.Visible = false; twfivButton.Visible = false; hundButton.Visible = false;
                betButton.Visible = false; clearBetButton.Visible = false; allIn.Visible = false;
                hitButton.Visible = true; standButton.Visible = true;
            }
            else
            {
                currBetLabel.Text = "";
                oneButton.Visible = true; fiveButton.Visible = true; tenButton.Visible = true; twfivButton.Visible = true; hundButton.Visible = true;
                betButton.Visible = true; clearBetButton.Visible = true; allIn.Visible = true;
                hitButton.Visible = false; standButton.Visible = false;
            }
        }

        public void SetHitButtonsVisible(bool enable) { hitButton.Visible = enable; }

        public bool GetHitButtonsVisible() { return hitButton.Visible; }

        public void SetStandButtonsVisible(bool enable) { standButton.Visible = enable; }

        public bool GetStandButtonsVisible() { return standButton.Visible; }

        private void clearBetButton_Click(object sender, EventArgs e)
        {
            blackJackForm.setBet(0);
            currBetLabel.Text = blackJackForm.getBet().ToString("C");
        }

        private void allInButton_Click(object sender, EventArgs e)
        {
            blackJackForm.setBet(GlobalData.getRiskMoney());
            currBetLabel.Text = blackJackForm.getBet().ToString("C");
            blackJackForm.PlaceBet();
            SmallScreen();
        }
    }
}