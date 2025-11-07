using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_Forms_Project
{
    public class PkPlayOpp
    {
        public Form FormType { get; set; }

        public string Name { get; set; }

        public bool Player { get; set; }

        public bool DealerC { get; set; }

        public bool SmallC { get; set; }

        public bool BigC { get; set; }

        public string ExpandedHand { get; set; }

        public int HandValue { get; set; }

        public PkPlayOpp(Form formType,  string name, bool isPlayer = false, bool isDealer = false, bool isSmallBlind = false, bool isBigBlind = false)
        {
            FormType = formType;
            Name = name;
            Player = isPlayer;
            DealerC = isDealer;
            SmallC = isSmallBlind;
            BigC = isBigBlind;
            ExpandedHand = string.Empty;
            HandValue = 0;
        }

    }
}
