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

        private SerialPort sp;
        private int    com_baudRate;
        private int    com_dataBits;
        private Parity com_parity;
        private StopBits com_stopBits;
        private Handshake com_handshake;
         

        public MainForm()
        {
            InitializeComponent();
            panelSettingsHiden = false;
            panelSettingsWidth = pnl_Settings.Width;
            isBtnSerialConnect = false;

            rb_baudRate_4800.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_9600.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_14400.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_19200.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_28800.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_38400.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_56000.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_57600.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_115200.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_128000.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_256000.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_460800.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_baudRate_custome.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            rb_dataBits_5.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_dataBits_6.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_dataBits_7.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_dataBits_8.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            rb_parity_none.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_parity_odd.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_parity_even.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_parity_mark.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_parity_space.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            rb_stopBits_1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_stopBits_1_5.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_stopBits_2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            rb_handshake_none.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_handshake_rts.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_handshake_xon.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_handshake_rts_xon.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (rb_baudRate_4800.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_4800.Text);
            if (rb_baudRate_9600.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_9600.Text);
            if (rb_baudRate_14400.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_14400.Text);
            if (rb_baudRate_19200.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_19200.Text);
            if (rb_baudRate_28800.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_28800.Text);
            if (rb_baudRate_38400.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_38400.Text);
            if (rb_baudRate_56000.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_56000.Text);
            if (rb_baudRate_57600.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_57600.Text);
            if (rb_baudRate_115200.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_115200.Text);
            if (rb_baudRate_128000.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_128000.Text);
            if (rb_baudRate_256000.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_256000.Text);
            if (rb_baudRate_460800.Checked) com_baudRate = Convert.ToInt32(rb_baudRate_460800.Text);
            if (rb_baudRate_custome.Checked) com_baudRate = Convert.ToInt32(tb_baudRateCustome.Text);

            if (rb_dataBits_5.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_5.Text);
            if (rb_dataBits_6.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_6.Text);
            if (rb_dataBits_7.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_7.Text);
            if (rb_dataBits_8.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_8.Text);

            if (rb_parity_none.Checked) com_parity = Parity.None;
            if (rb_parity_odd.Checked) com_parity = Parity.Odd;
            if (rb_parity_even.Checked) com_parity = Parity.Even;
            if (rb_parity_mark.Checked) com_parity = Parity.Mark;
            if (rb_parity_space.Checked) com_parity = Parity.Space;

            if (rb_stopBits_1.Checked) com_stopBits = StopBits.One;
            if (rb_stopBits_1_5.Checked) com_stopBits = StopBits.OnePointFive;
            if (rb_stopBits_2.Checked) com_stopBits = StopBits.Two;

            if (rb_handshake_none.Checked) com_handshake = Handshake.None;
            if (rb_handshake_rts.Checked) com_handshake = Handshake.RequestToSend;
            if (rb_handshake_xon.Checked) com_handshake = Handshake.XOnXOff;
            if (rb_handshake_rts_xon.Checked) com_handshake = Handshake.RequestToSendXOnXOff;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            serialPortScan();
            radioButtons_CheckedChanged(null, null);
        }

        private void tb_baudRateCustome_TextChanged(object sender, EventArgs e)   //prevent from entering chars instead numbers
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_baudRateCustome.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb_baudRateCustome.Text = tb_baudRateCustome.Text.Remove(tb_baudRateCustome.Text.Length - 1);
            }
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
                sp.Close();
                btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Disconnected_32px;
                this.Text = "Terrarium ";
            }
            else
            {
                try
                {
                    sp = new SerialPort((string)cmb_SerialPortList.SelectedItem, com_baudRate, com_parity, com_dataBits, com_stopBits);
                }
                catch
                {
                    MessageBox.Show("Port not available");
                    return;
                }
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



