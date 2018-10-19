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
        private bool panelSettingsHiden;
        private bool isBtnSerialConnect;
        private Properties.Settings ps = Properties.Settings.Default;
        public MainForm()
        {
            InitializeComponent();
            panelSettingsHiden = false;
            panelSettingsWidth = pnl_Settings.Width;
            isBtnSerialConnect = false;
            
        }

        private void btn_Settings_Click(object sender, EventArgs e) => tmr_MenuSlide.Start();


        private void tmr_MenuSlide_Tick(object sender, EventArgs e)
        {
            if (panelSettingsHiden == true)
            {
                pnl_Settings.Width += 25;
                if(pnl_Settings.Width >= panelSettingsWidth)
                {
                    tmr_MenuSlide.Stop();
                    panelSettingsHiden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_Settings.Width -= 25;
                if (pnl_Settings.Width <= 0)
                {
                    tmr_MenuSlide.Stop();
                    panelSettingsHiden = true;
                    this.Refresh();
                }
            }

            this.Text = "Terrarium " + ps.SerialPortName;
        }

        
        private void btn_SerialConnect_Click(object sender, EventArgs e)
        {
            if (isBtnSerialConnect == true)
            {
                btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Disconnected_32px;
                
            }
            else
            {
                btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Connected_32px;
            }
            isBtnSerialConnect ^= true;


        }

        private void btn_CleanTxField_Click(object sender, EventArgs e) => rtb_Tx.Clear();

        private void btn_CleanRxField_Click(object sender, EventArgs e) => rtb_Rx.Clear();
        
    }
}



