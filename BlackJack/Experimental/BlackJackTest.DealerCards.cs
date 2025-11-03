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
    public partial class DealerCardForm : Form
    {
        public DealerCardForm()
        {
            InitializeComponent();
            this.ControlBox = false;
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
            int x = (screenWidth - formWidth) / 2; // Center horizontally
            int y = 10; // Start at the top

            this.Location = new System.Drawing.Point(x, y);
        }

        public string getDealerEHLabel() { return dealerEHLabel.Text; }

        public void setDealerEHLabel(string value) { dealerEHLabel.Text = value; }

        public string getDealerHandLabel() { return dealerHandLabel.Text; }

        public void setDealerHandLabel(string value) { dealerHandLabel.Text = value; } 
    }
}
