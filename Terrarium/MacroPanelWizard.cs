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
    public partial class MacroPanelWizard : Form
    {
        public MacroPanelWizard()
        {
            InitializeComponent();
            macroField1.btnClickEvent += new EventHandler(Button_Click);
        }


        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Btn Presed");
        }
    }
}
