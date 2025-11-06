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
    public partial class PkButtonsForm : Form
    {
        private PokerForm pokerForm;
        public PkButtonsForm(PokerForm poker)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.pokerForm = poker;
            PositionForm();
        }

        private void PositionForm()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width; int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width; int formHeight = this.Height;
            // Calculate the position
            int x = screenWidth - formWidth;
            int y = screenHeight - formHeight;
            this.Location = new System.Drawing.Point(x, y);
        }

        private void PkButtonsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            pokerForm.ReturnToMain();   
        }
    }
}
