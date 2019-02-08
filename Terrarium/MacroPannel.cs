using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terrarium
{
    public partial class MacroPannel : UserControl
    {
        private bool VisibleBotomPanel = false;
        private Size minSize = new Size(619, 100);

        public MacroPannel()
        {
            InitializeComponent();
        }
       
        public override Size MinimumSize
        {
            get { return base.MinimumSize; }
            set { base.MinimumSize = minSize; }
        }

        public bool ShouldSerializeMaximumSize()
        {
            return false;
        }

        private void ResetMaximumSize()
        {
            base.MaximumSize = minSize;
        }

        public bool VisibleMacroButtons
        {   
            get {return VisibleBotomPanel; }
                         
            set
            {
                VisibleBotomPanel = value;
                if (VisibleBotomPanel == true)
                {
                    mainLayoutPanel.RowStyles[1].SizeType = SizeType.Absolute;
                    mainLayoutPanel.RowStyles[1].Height = 0F;
                    mainLayoutPanel.Height = 25;
                    MinimumSize = new Size(619, 25);

                }
                else
                {
                    mainLayoutPanel.RowStyles[1].SizeType = SizeType.Absolute;
                    mainLayoutPanel.RowStyles[1].Height = 75F;
                    mainLayoutPanel.Height = 100;
                    MinimumSize = new Size(619, 100);

                }

            }
        }

    }
}
