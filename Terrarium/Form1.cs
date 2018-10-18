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
    public partial class MainForm : Form
    {
        int panelSettingsWidth;
        bool panelSettingsHiden;
        public MainForm()
        {
            InitializeComponent();
            panelSettingsHiden = false;
            panelSettingsWidth = pnl_Settings.Width;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelSettingsHiden == true)
            {
                pnl_Settings.Width += 25;
                if(pnl_Settings.Width >= panelSettingsWidth)
                {
                    timer1.Stop();
                    panelSettingsHiden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_Settings.Width -= 25;
                if (pnl_Settings.Width <= 0)
                {
                    timer1.Stop();
                    panelSettingsHiden = true;
                    this.Refresh();
                }
            }
           
        }
    }
}



