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
    public partial class PkPlayerCardForm : Form
    {
        bool dealerChip = false, small = false, big = false;
        public PkPlayerCardForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.ControlBox = false;
            //PositionForm();
        }
        public void SetName(string name) { this.Text = name; }

        public void FormStartingPosition(int x, int y) { this.Location = new System.Drawing.Point(x, y); }

        public bool GetDealer() { return dealerChip; }

        public bool GetSmall() { return small; }

        public bool GetBig() { return big; }

        public void SetDealer(bool b) { dealerChip = b; }

        public void SetSmall(bool b) { small = b; }

        public void SetBig(bool b) { big = b; }

        
    }
}
