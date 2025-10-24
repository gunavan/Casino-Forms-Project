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
    public partial class BlackJackCardSelection : Form
    {
        string newCard, suit, value;

        public BlackJackCardSelection()
        {
            InitializeComponent();
            //cvComboBox.SelectedIndex = 0;
            this.ControlBox = false;
            
        }

        public string Card
        {
            get { return newCard; }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            // value
            value = cvComboBox.SelectedItem.ToString();

            // suit
            if (hCheckBox.Checked) { suit = "h"; }
            else if (dCheckBox.Checked) { suit = "d"; }
            else if (cCheckBox.Checked) { suit = "c"; }
            else if (sCheckBox.Checked) { suit = "s"; }
            
            if (suit != null && value != null) {
                newCard = value + suit;
                this.Close();
            } else {
                MessageBox.Show("Please select a suit");
            }
        }

        private void hCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hCheckBox.Checked) {
                dCheckBox.Checked = false; cCheckBox.Checked = false; sCheckBox.Checked = false;
            }
        }

        private void dCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dCheckBox.Checked) {
                hCheckBox.Checked = false; cCheckBox.Checked = false; sCheckBox.Checked = false;
            }
        }

        private void sCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sCheckBox.Checked) {
                hCheckBox.Checked = false; cCheckBox.Checked = false; dCheckBox.Checked = false;
            }
        }

        private void cCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cCheckBox.Checked) {
                hCheckBox.Checked = false; dCheckBox.Checked = false; sCheckBox.Checked = false;
            }
        }
    }
}
