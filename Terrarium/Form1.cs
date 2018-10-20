using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;

namespace Terrarium
{
    public partial class MainForm : Form
    {
        int panelSettingsWidth;
        private bool panelSettingsHiden;
        private bool isBtnSerialConnect;
        private Properties.Settings ps = Properties.Settings.Default;
        private string[] serialPortList;


        public MainForm()
        {
            InitializeComponent();
            panelSettingsHiden = false;
            panelSettingsWidth = pnl_Settings.Width;
            isBtnSerialConnect = false;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            serialPortScan();
        }

        

        private void btn_Settings_Click(object sender, EventArgs e) => tmr_MenuSlide.Start();


        private void tmr_MenuSlide_Tick(object sender, EventArgs e)
        {
            if (panelSettingsHiden == true)
            {
                pnl_Settings.Width += 50;
                if(pnl_Settings.Width >= panelSettingsWidth)
                {
                    tmr_MenuSlide.Stop();
                    panelSettingsHiden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_Settings.Width -= 50;
                if (pnl_Settings.Width <= 0)
                {
                    tmr_MenuSlide.Stop();
                    panelSettingsHiden = true;
                    this.Refresh();
                }
            }
        }

        
        private void btn_SerialConnect_Click(object sender, EventArgs e)
        {
            if (isBtnSerialConnect == true)
            {
                btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Disconnected_32px;
                this.Text = "Terrarium ";
            }
            else
            {
                btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Connected_32px;
                this.Text = "Terrarium " + (string)cmb_SerialPortList.SelectedItem;
            }
            isBtnSerialConnect ^= true;


        }

        private void btn_CleanTxField_Click(object sender, EventArgs e) => rtb_Tx.Clear();

        private void btn_CleanRxField_Click(object sender, EventArgs e) => rtb_Rx.Clear();

        private void serialPortScan()
        {
            serialPortList = SerialPort.GetPortNames();
            string tmpPortList = (string)cmb_SerialPortList.SelectedItem;

            if (serialPortList.Contains(tmpPortList))
            {
                cmb_SerialPortList.Items.Clear();
                foreach (string item in serialPortList)
                {
                    cmb_SerialPortList.Items.Add(item);
                    cmb_SerialPortList.SelectedIndex = cmb_SerialPortList.Items.IndexOf(tmpPortList);
                }
            }
            else
            {
                cmb_SerialPortList.Items.Clear();
                foreach (string item in serialPortList)
                {
                    cmb_SerialPortList.Items.Add(item);
                    cmb_SerialPortList.SelectedIndex = 0;
                }
            }
        }

        private void btn_SerialPortRefresh_Click(object sender, EventArgs e)
        {
            serialPortScan();
        }


    }
}



