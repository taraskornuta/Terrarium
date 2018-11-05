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
using System.Collections;
using System.Text.RegularExpressions;

namespace Terrarium
{

    public partial class MainForm : Form
    {
        int panelSettingsWidth;
        private bool panelSettingsHiden;
        private Properties.Settings ps = Properties.Settings.Default;
        private string[] serialPortList;

        private string com_portName;
        private int com_baudRate;
        private int com_baudRateCustome;
        private int com_dataBits;
        private Parity com_parity;
        private StopBits com_stopBits;
        private Handshake com_handshake;
        SerialClient serClient;
        private bool IsOpenBtnClicked = false;



        public MainForm()
        {
            InitializeComponent();
            panelSettingsHiden = false;
            panelSettingsWidth = pnl_Settings.Width;

            rb_baudRate_4800.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_9600.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_14400.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_19200.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_28800.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_38400.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_56000.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_57600.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_115200.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_128000.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_256000.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_460800.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);
            rb_baudRate_custome.CheckedChanged += new EventHandler(rb_baudRate_CheckedChanged);

            rb_dataBits_5.CheckedChanged += new EventHandler(rb_dataBits_CheckedChanged);
            rb_dataBits_6.CheckedChanged += new EventHandler(rb_dataBits_CheckedChanged);
            rb_dataBits_7.CheckedChanged += new EventHandler(rb_dataBits_CheckedChanged);
            rb_dataBits_8.CheckedChanged += new EventHandler(rb_dataBits_CheckedChanged);

            rb_parity_none.CheckedChanged += new EventHandler(rb_parity_CheckedChanged);
            rb_parity_odd.CheckedChanged += new EventHandler(rb_parity_CheckedChanged);
            rb_parity_even.CheckedChanged += new EventHandler(rb_parity_CheckedChanged);
            rb_parity_mark.CheckedChanged += new EventHandler(rb_parity_CheckedChanged);
            rb_parity_space.CheckedChanged += new EventHandler(rb_parity_CheckedChanged);

            rb_stopBits_1.CheckedChanged += new EventHandler(rb_stopBits_CheckedChanged);
            rb_stopBits_1_5.CheckedChanged += new EventHandler(rb_stopBits_CheckedChanged);
            rb_stopBits_2.CheckedChanged += new EventHandler(rb_stopBits_CheckedChanged);

            rb_handshake_none.CheckedChanged += new EventHandler(rb_handshake_CheckedChanged);
            rb_handshake_rts.CheckedChanged += new EventHandler(rb_handshake_CheckedChanged);
            rb_handshake_xon.CheckedChanged += new EventHandler(rb_handshake_CheckedChanged);
            rb_handshake_rts_xon.CheckedChanged += new EventHandler(rb_handshake_CheckedChanged);

        }

        private void rb_baudRate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {

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
                    if (rb_baudRate_custome.Checked) com_baudRate = 0;

                    if (serClient != null)
                    {
                        serClient.SetBaudrate(com_baudRate);
                    }
                }
            }
        }

        private void rb_dataBits_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    if (rb_dataBits_5.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_5.Text);
                    if (rb_dataBits_6.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_6.Text);
                    if (rb_dataBits_7.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_7.Text);
                    if (rb_dataBits_8.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_8.Text);

                    if (serClient != null)
                    {
                        serClient.SetDataBits(com_dataBits);
                    }
                }
            }
        }

        private void rb_parity_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    if (rb_parity_none.Checked) com_parity = Parity.None;
                    if (rb_parity_odd.Checked) com_parity = Parity.Odd;
                    if (rb_parity_even.Checked) com_parity = Parity.Even;
                    if (rb_parity_mark.Checked) com_parity = Parity.Mark;
                    if (rb_parity_space.Checked) com_parity = Parity.Space;

                    if (serClient != null)
                    {
                        serClient.SetParity(com_parity);
                    }
                }
            }
        }

        private void rb_stopBits_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    if (rb_stopBits_1.Checked) com_stopBits = StopBits.One;
                    if (rb_stopBits_1_5.Checked) com_stopBits = StopBits.OnePointFive;
                    if (rb_stopBits_2.Checked) com_stopBits = StopBits.Two;

                    if (serClient != null)
                    {
                        serClient.SetStopBits(com_stopBits);
                    }
                }
            }
        }

        private void rb_handshake_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    if (rb_handshake_none.Checked) com_handshake = Handshake.None;
                    if (rb_handshake_rts.Checked) com_handshake = Handshake.RequestToSend;
                    if (rb_handshake_xon.Checked) com_handshake = Handshake.XOnXOff;
                    if (rb_handshake_rts_xon.Checked) com_handshake = Handshake.RequestToSendXOnXOff;

                    if (serClient != null)
                    {
                        serClient.SetHandshake(com_handshake);
                    }
                }
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            SettingsGet();
            FillControlValues();
            SerialPortScan();

            if (com_portName == null)
            {
                com_portName = "COM1";
            }
            serClient = new SerialClient(com_portName, com_baudRate, com_dataBits, com_parity, com_stopBits, com_handshake);
            serClient.OnReceiving += new EventHandler<DataStreamEventArgs>(receiveHandler);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SettingsSave();
            serClient.Close();

            serClient.OnReceiving -= new EventHandler<DataStreamEventArgs>(receiveHandler);
            serClient.Dispose();
        }

        private void receiveHandler(object sender, DataStreamEventArgs e)
        {
            SetText(Encoding.ASCII.GetString(e.Response));
        }


        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.rtb_Rx.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rtb_Rx.AppendText(text);
            }
        }

        private void FillControlValues()
        {
            tb_baudRateCustome.Text = ps.SerialBaudCustome.ToString();

            switch (ps.SerialPortBoude)
            {
                case 0:                                     //custome value
                    rb_baudRate_custome.Checked = true;
                    break;
                case 4800:
                    rb_baudRate_4800.Checked = true;
                    break;
                case 9600:
                    rb_baudRate_9600.Checked = true;
                    break;
                case 14400:
                    rb_baudRate_14400.Checked = true;
                    break;
                case 19200:
                    rb_baudRate_19200.Checked = true;
                    break;
                case 28800:
                    rb_baudRate_28800.Checked = true;
                    break;
                case 38400:
                    rb_baudRate_38400.Checked = true;
                    break;
                case 56000:
                    rb_baudRate_56000.Checked = true;
                    break;
                case 57600:
                    rb_baudRate_57600.Checked = true;
                    break;
                case 115200:
                    rb_baudRate_115200.Checked = true;
                    break;
                case 128000:
                    rb_baudRate_128000.Checked = true;
                    break;
                case 256000:
                    rb_baudRate_256000.Checked = true;
                    break;
                case 460800:
                    rb_baudRate_460800.Checked = true;
                    break;
                default:
                    break;
            }

            switch (ps.SerialDataBits)
            {
                case 5:
                    rb_dataBits_5.Checked = true;
                    break;
                case 6:
                    rb_dataBits_6.Checked = true;
                    break;
                case 7:
                    rb_dataBits_7.Checked = true;
                    break;
                case 8:
                    rb_dataBits_8.Checked = true;
                    break;
                default:
                    break;
            }

            switch (ps.SerialPortParity)
            {
                case "None":
                    rb_parity_none.Checked = true;
                    break;
                case "Odd":
                    rb_parity_odd.Checked = true;
                    break;
                case "Even":
                    rb_parity_even.Checked = true;
                    break;
                case "Mark":
                    rb_parity_mark.Checked = true;
                    break;
                case "Space":
                    rb_parity_space.Checked = true;
                    break;
                default:
                    break;
            }

            switch (ps.SerialStopBits)
            {               
                case "One":
                    rb_stopBits_1.Checked = true;
                    break;
                case "Two":
                    rb_stopBits_2.Checked = true;
                    break;
                case "OnePointFive":
                    rb_stopBits_1_5.Checked = true;
                    break;
                default:
                    break;
            }

            switch (ps.SerialHandshake)
            {
                case "None":
                    rb_handshake_none.Checked = true;
                    break;
                case "XOnXOff":
                    rb_handshake_xon.Checked = true;
                    break;
                case "RequestToSend":
                    rb_handshake_rts.Checked = true;
                    break;
                case "RequestToSendXOnXOff":
                    rb_handshake_rts_xon.Checked = true;
                    break;
                default:
                    break;
            }
        }


        private void SettingsSave()
        {
            ps.SerialPortName = com_portName;
            ps.SerialPortBoude = com_baudRate;
            ps.SerialBaudCustome = com_baudRateCustome;
            ps.SerialDataBits = com_dataBits;
            ps.SerialStopBits = Convert.ToString(com_stopBits);
            ps.SerialHandshake = Convert.ToString(com_handshake);
            ps.SerialPortParity = Convert.ToString(com_parity);

            ps.Save();
        }

        private void SettingsGet()
        {
            com_portName = ps.SerialPortName;
            com_baudRate = ps.SerialPortBoude;
            com_dataBits = ps.SerialDataBits;
            com_baudRateCustome = ps.SerialBaudCustome;
            com_stopBits = (StopBits)Enum.Parse(typeof(StopBits), ps.SerialStopBits);
            com_handshake = (Handshake)Enum.Parse(typeof(Handshake), ps.SerialHandshake);
            com_parity = (Parity)Enum.Parse(typeof(Parity), ps.SerialPortParity);

        }



        private void tb_baudRateCustome_TextChanged(object sender, EventArgs e)   //prevent from entering chars instead numbers
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_baudRateCustome.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb_baudRateCustome.Text = tb_baudRateCustome.Text.Remove(tb_baudRateCustome.Text.Length - 1);
            }
            else
            {
                com_baudRateCustome = Convert.ToInt32(tb_baudRateCustome.Text);
            }
        }

        private void btn_Settings_Click(object sender, EventArgs e) => tmr_MenuSlide.Start();


        private void tmr_MenuSlide_Tick(object sender, EventArgs e)
        {
            if (panelSettingsHiden == true)
            {
                pnl_Settings.Width += 50;
                if (pnl_Settings.Width >= panelSettingsWidth)
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
            if (IsOpenBtnClicked == false)
            {
                serClient.SetPortName(com_portName);
                serClient.SetBaudrate(com_baudRate);
                serClient.SetParity(com_parity);
                serClient.SetDataBits(com_dataBits);
                serClient.SetStopBits(com_stopBits);
                serClient.SetHandshake(com_handshake);

                serClient = new SerialClient(com_portName, com_baudRate, com_dataBits, com_parity, com_stopBits, com_handshake);
                serClient.OnReceiving += new EventHandler<DataStreamEventArgs>(receiveHandler);

                if (serClient.Open() == true)
                {
                    SendTxtToTextBox("Serial is Open", Color.Aqua);
                    btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Connected_32px;
                    this.Text = "Terrarium " + (string)cmb_SerialPortList.SelectedItem;
                    Match Match = Regex.Match(com_portName, "[0-9]");
                    lbl_ComNumber.Text = Match.Value;
                    cmb_SerialPortList.Enabled = false;
                }
                else
                {
                    serClient.Close();
                    SendTxtToTextBox("Serial port ERROR", Color.Red);
                    cmb_SerialPortList.Enabled = true;
                    IsOpenBtnClicked = false;
                    return;
                }
            }
            else
            {
                serClient.Close();
                SendTxtToTextBox("Serial is Close", Color.Aqua);
                btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Disconnected_32px;
                this.Text = "Terrarium ";
                cmb_SerialPortList.Enabled = true;
            }
            IsOpenBtnClicked ^= true;
        }



        private void btn_CleanTxField_Click(object sender, EventArgs e) => rtb_Tx.Clear();

        private void btn_CleanRxField_Click(object sender, EventArgs e) => rtb_Rx.Clear();


        private void SerialPortScan()
        {
            serialPortList = SerialPort.GetPortNames();
            Array.Sort(serialPortList, (x, y) => x.CompareTo(y));

            string tmpPortName = com_portName;

            if (serialPortList.Contains(tmpPortName))
            {
                cmb_SerialPortList.Items.Clear();
                foreach (string item in serialPortList)
                {
                    cmb_SerialPortList.Items.Add(item);
                    cmb_SerialPortList.SelectedIndex = cmb_SerialPortList.Items.IndexOf(tmpPortName);
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
            com_portName = (string)cmb_SerialPortList.SelectedItem;
        }

        private void btn_SerialPortRefresh_Click(object sender, EventArgs e)
        {
            if (serClient.IsOpen() == false)
            {
                SerialPortScan();
            }
        }

        public void SendTxtToTextBox(string data, Color color)
        {
            rtb_Rx.SelectionStart = rtb_Rx.TextLength;
            rtb_Rx.SelectionLength = 0;
            rtb_Rx.SelectionColor = color;
            rtb_Rx.SelectedText = string.Empty;
            rtb_Rx.AppendText(data + "\r\n");
            rtb_Rx.SelectionColor = rtb_Rx.ForeColor;
            rtb_Rx.ScrollToCaret();
        }

        private void cmb_SerialPortList_SelectedValueChanged(object sender, EventArgs e)
        {
            com_portName = (string)cmb_SerialPortList.SelectedItem;
        }

        private void rtb_Tx_KeyPress(object sender, KeyPressEventArgs e)  //used for greping chars from rtb_Tx
        {
            char c = e.KeyChar;
            if (!char.IsControl(c))
            {
                byte[] buff = new byte[1];
                buff[0] = Convert.ToByte(c);
                serClient.Transmit(buff);
            }
            else
            {
                switch (Convert.ToByte(c))
                {
                    case 0x03:        //Ctrl+C
                        Clipboard.SetText(rtb_Tx.SelectedText);
                        break;

                    case 0x16:        //Ctrl+V                      
                        string tmp = Clipboard.GetText();
                        byte[] buff = Encoding.UTF8.GetBytes(tmp);
                        serClient.Transmit(buff);
                        break;


                }
            }
        }


        private void btn_SerialSend_Click(object sender, EventArgs e)
        {
            serClient.Transmit(Encoding.UTF8.GetBytes(tb_TxString.Text));
        }

        private void tb_TxString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_SerialSend.PerformClick();
            }
        }
    }
}



