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
        public MacroPannel()
        {
            InitializeComponent();
        }

        private Size minSize = new Size(619, 100);
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
    }
}
