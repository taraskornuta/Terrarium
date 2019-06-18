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
            this.dataFormatSwitch.DataFormat = dataFormat;
        }

        public double FormOpacity
        {          
            get => this.Opacity;
            set => this.Opacity = value;
        }
    }
}
