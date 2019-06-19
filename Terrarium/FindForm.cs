using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terrarium
{
    public partial class FindForm : Form
    {

        public FindForm(eDataFormat dataFormat)
        {
            InitializeComponent();

            if (dataFormat <= eDataFormat.HEX)
            {
                this.dataFormatSwitch.DataFormat = dataFormat;
            }
            else
            {
                this.dataFormatSwitch.DataFormat = dataFormat - 3;
            }  
        }

        public double FormOpacity
        {          
            get => this.Opacity;
            set => this.Opacity = value;
        }

        private void FindForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1D;
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
