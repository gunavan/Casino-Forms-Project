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
    public partial class PkOpponentsSelect : Form
    {
        public int opponents;
        public PkOpponentsSelect()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public int GetOpponents() { return opponents; }

        private void button1_Click(object sender, EventArgs e)
        {
            opponents = 1;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opponents = 2;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opponents = 3;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opponents = 4;
            this.Close();
        }
    }
}
