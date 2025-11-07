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
        bool dealerChip = false, small = false, big = false;
        public PkOppForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.Manual;
        }

        public bool GetDealer() { return dealerChip; }

        public bool GetSmall() { return small; }

        public bool GetBig() { return big; }

        public void SetDealer(bool b) { dealerChip = b; }

        public void SetSmall(bool b) { small = b; }

        public void SetBig(bool b) { big = b; }

        public int GetWidth() { return this.Width; }

        public int GetHeight() { return this.Height; }

        public void FormStartingPosition(int x, int y) { this.Location = new System.Drawing.Point(x, y); }

        public void SetName(string name) { this.Text = name; }
    }
}
