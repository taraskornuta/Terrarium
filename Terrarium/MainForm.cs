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
using System.Threading;
using System.IO;

namespace Terrarium
{

    public partial class MainForm : Form
    {
        private int panelSettingsWidth;

        private SerialCom serClient = new SerialCom("COM1");
        private MacroPanelWizard macroWizard = new MacroPanelWizard();
        private ConfigManager macroWizardConf = new ConfigManager();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private Properties.Settings ps = Properties.Settings.Default;
        private Dictionary<string, string> serialPortList = new Dictionary<string, string>();
        private FindForm findForm = new FindForm();
        private string com_portName;
        private int com_baudRate;
        private int com_baudRateCustome;
        private int com_dataBits;
        private Parity com_parity;
        private StopBits com_stopBits;
        private Handshake com_handshake;
       
        private int RxDataCounter = 0;
        private int TxDataCounter = 0;

        private bool isPanelMacroHiden;
        private bool isPanelSettingsHiden;


        private bool isBtnOpenPress = false;

        public MainForm()
        {
            InitializeComponent();

            panelSettingsWidth = pnl_Settings.Width;
            SettingsGet();
            btn_PanelPortSettings_Click(null, null);  //perform click to apply settings
            btn_PanelReceiving_Click(null, null);
            btn_PanelTransmiting_Click(null, null);

            #region EventHandlersInit 

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

            macroPannel.BtnSendClick += new EventHandler(btn_SerialSend_Click);
            macroPannel.ButtonSendEvent += new EventHandler(btn_SerialSend_Click); // need to catch presed Enter key 
            macroPannel.BtnMacroSettingsClick += new EventHandler(btn_MacroPanelWizard_Click);

            macroPannel.BtnM1Click += new EventHandler(btn_m1_Click);
            macroPannel.BtnM2Click += new EventHandler(btn_m2_Click);
            macroPannel.BtnM3Click += new EventHandler(btn_m3_Click);
            macroPannel.BtnM4Click += new EventHandler(btn_m4_Click);
            macroPannel.BtnM5Click += new EventHandler(btn_m5_Click);
            macroPannel.BtnM6Click += new EventHandler(btn_m6_Click);
            macroPannel.BtnM7Click += new EventHandler(btn_m7_Click);
            macroPannel.BtnM8Click += new EventHandler(btn_m8_Click);
            macroPannel.BtnM9Click += new EventHandler(btn_m9_Click);
            macroPannel.BtnM10Click += new EventHandler(btn_m10_Click);
            macroPannel.BtnM11Click += new EventHandler(btn_m11_Click);
            macroPannel.BtnM12Click += new EventHandler(btn_m12_Click);
            macroPannel.BtnM13Click += new EventHandler(btn_m13_Click);
            macroPannel.BtnM14Click += new EventHandler(btn_m14_Click);
            macroPannel.BtnM15Click += new EventHandler(btn_m15_Click);
            macroPannel.BtnM16Click += new EventHandler(btn_m16_Click);
            macroPannel.BtnM17Click += new EventHandler(btn_m17_Click);
            macroPannel.BtnM18Click += new EventHandler(btn_m18_Click);
            macroPannel.BtnM19Click += new EventHandler(btn_m19_Click);
            macroPannel.BtnM20Click += new EventHandler(btn_m20_Click);

            macroWizard.BtnM1TextChange += new EventHandler(btn_m1_TextChange);
            macroWizard.BtnM2TextChange += new EventHandler(btn_m2_TextChange);
            macroWizard.BtnM3TextChange += new EventHandler(btn_m3_TextChange);
            macroWizard.BtnM4TextChange += new EventHandler(btn_m4_TextChange);
            macroWizard.BtnM5TextChange += new EventHandler(btn_m5_TextChange);
            macroWizard.BtnM6TextChange += new EventHandler(btn_m6_TextChange);
            macroWizard.BtnM7TextChange += new EventHandler(btn_m7_TextChange);
            macroWizard.BtnM8TextChange += new EventHandler(btn_m8_TextChange);
            macroWizard.BtnM9TextChange += new EventHandler(btn_m9_TextChange);
            macroWizard.BtnM10TextChange += new EventHandler(btn_m10_TextChange);
            macroWizard.BtnM11TextChange += new EventHandler(btn_m11_TextChange);
            macroWizard.BtnM12TextChange += new EventHandler(btn_m12_TextChange);
            macroWizard.BtnM13TextChange += new EventHandler(btn_m13_TextChange);
            macroWizard.BtnM14TextChange += new EventHandler(btn_m14_TextChange);
            macroWizard.BtnM15TextChange += new EventHandler(btn_m15_TextChange);
            macroWizard.BtnM16TextChange += new EventHandler(btn_m16_TextChange);
            macroWizard.BtnM17TextChange += new EventHandler(btn_m17_TextChange);
            macroWizard.BtnM18TextChange += new EventHandler(btn_m18_TextChange);
            macroWizard.BtnM19TextChange += new EventHandler(btn_m19_TextChange);
            macroWizard.BtnM20TextChange += new EventHandler(btn_m20_TextChange);

            macroWizard.BtnM1Click += new EventHandler(btn_m1_Click);
            macroWizard.BtnM2Click += new EventHandler(btn_m2_Click);
            macroWizard.BtnM3Click += new EventHandler(btn_m3_Click);
            macroWizard.BtnM4Click += new EventHandler(btn_m4_Click);
            macroWizard.BtnM5Click += new EventHandler(btn_m5_Click);
            macroWizard.BtnM6Click += new EventHandler(btn_m6_Click);
            macroWizard.BtnM7Click += new EventHandler(btn_m7_Click);
            macroWizard.BtnM8Click += new EventHandler(btn_m8_Click);
            macroWizard.BtnM9Click += new EventHandler(btn_m9_Click);
            macroWizard.BtnM10Click += new EventHandler(btn_m10_Click);
            macroWizard.BtnM11Click += new EventHandler(btn_m11_Click);
            macroWizard.BtnM12Click += new EventHandler(btn_m12_Click);
            macroWizard.BtnM13Click += new EventHandler(btn_m13_Click);
            macroWizard.BtnM14Click += new EventHandler(btn_m14_Click);
            macroWizard.BtnM15Click += new EventHandler(btn_m15_Click);
            macroWizard.BtnM16Click += new EventHandler(btn_m16_Click);
            macroWizard.BtnM17Click += new EventHandler(btn_m17_Click);
            macroWizard.BtnM18Click += new EventHandler(btn_m18_Click);
            macroWizard.BtnM19Click += new EventHandler(btn_m19_Click);
            macroWizard.BtnM20Click += new EventHandler(btn_m20_Click);

            macroWizard.BtnSaveConfigClick += new EventHandler(btn_SaveConfig_Click);
            macroWizard.BtnLoadConfigClick += new EventHandler(btn_LoadConfig_Click);
            dropDownPanelSettings.ButtonEvent += new EventHandler(btn_PanelPortSettings_Click);
            dropDownPanelReceiving.ButtonEvent += new EventHandler(btn_PanelReceiving_Click);
            dropDownPanelTransmiting.ButtonEvent += new EventHandler(btn_PanelTransmiting_Click);

            nrtb_Rx.FindMenuEventHandler += new EventHandler(menuFind_Click);
            findForm.BtnFindEventHandler += new EventHandler(btnFind_Click);
            #endregion
        }

        public eDataFormat GetDataFormatPanel
        {
            get => dataFormatPanel.DataFormat;
        }

        #region SidePanelSettings
        private void rb_baudRate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
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

                if (rb_baudRate_custome.Checked)
                {
                    tb_baudRateCustome.Enabled = true;
                    if 
                    (
                        String.IsNullOrEmpty(tb_baudRateCustome.Text) ||
                        String.IsNullOrWhiteSpace(tb_baudRateCustome.Text) ||
                        "0" == tb_baudRateCustome.Text)
                    {
                        tb_baudRateCustome.Text = "1";
                        MessageBox.Show("Baudrate should have positive value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        com_baudRate = Convert.ToInt32(tb_baudRateCustome.Text);
                    }
                }
                else                                    // if custome Baudrate radio button not checked, tb_baudRateCustome disabled
                {
                    tb_baudRateCustome.Enabled = false;
                }

                serClient.PortBaudRate = com_baudRate;              
            }
        }

        private void rb_dataBits_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                if (rb_dataBits_5.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_5.Text);
                if (rb_dataBits_6.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_6.Text);
                if (rb_dataBits_7.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_7.Text);
                if (rb_dataBits_8.Checked) com_dataBits = Convert.ToInt32(rb_dataBits_8.Text);

                serClient.PortDataBits = com_dataBits;               
            }
        }

        private void rb_parity_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                 if (rb_parity_none.Checked) com_parity = Parity.None;
                 if (rb_parity_odd.Checked) com_parity = Parity.Odd;
                 if (rb_parity_even.Checked) com_parity = Parity.Even;
                 if (rb_parity_mark.Checked) com_parity = Parity.Mark;
                 if (rb_parity_space.Checked) com_parity = Parity.Space;

                 serClient.PortParity = com_parity;             
            }
        }

        private void rb_stopBits_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                if (rb_stopBits_1.Checked) com_stopBits = StopBits.One;
                if (rb_stopBits_1_5.Checked) com_stopBits = StopBits.OnePointFive;
                if (rb_stopBits_2.Checked) com_stopBits = StopBits.Two;

                serClient.PortStopBits = com_stopBits;              
            }
        }

        private void rb_handshake_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                if (rb_handshake_none.Checked) com_handshake = Handshake.None;
                if (rb_handshake_rts.Checked) com_handshake = Handshake.RequestToSend;
                if (rb_handshake_xon.Checked) com_handshake = Handshake.XOnXOff;
                if (rb_handshake_rts_xon.Checked) com_handshake = Handshake.RequestToSendXOnXOff;
                if (serClient != null) serClient.PortHandshake = com_handshake;
            }
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillControlValues();

            int portCount = SerialPortScan();
            if (portCount == 0) SetTxtToStatusLable("NO PORTS FOUND", Color.WhiteSmoke);
            else SetTxtToStatusLable("FOUND PORTS " + portCount, Color.WhiteSmoke);

            if (com_portName == null) com_portName = "COM1";

            serClient = new SerialCom(com_portName);

            if (ps.macroPanelConfFileLocation != null && File.Exists(ps.macroPanelConfFileLocation) == true)
            {
                macroWizardConf.LoadConfig(ps.macroPanelConfFileLocation);
                macroWizardFillConfigs();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SettingsSave();
            serClient.Close();
            serClient.Dispose();
        }

        protected void SerialErrorHandler(object sender, EventArgs e)
        {
            serClient.Close();

            SetTxtToStatusLable("PORT ERROR", Color.Red);
            this.Invoke(new Action(() =>
            {
                btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Disconnected_32px;
                cmb_SerialPortList.Enabled = true;
                btn_SerialConnect.Enabled = true;
                isBtnOpenPress = false;

            }));


            cmb_SerialPortList.Enabled = true;
            btn_SerialConnect.Enabled = true;
            isBtnOpenPress = false;
        }

        private void SerialReceiveHandler(object sender, DataStreamEventArgs e)
        {
            SetText(e.Response);
        }

        delegate void SetTextCallback(byte[] data);

       
        private void SetText(byte[] data)
        {
            if (nrtb_Rx.RichTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                TextHelper.ByteFormatPrint(nrtb_Rx, data, dataFormatPanel.DataFormat, cb_Sort.Checked, (int)nmn_ByteSort.Value, cb_RxAutoscroll.Checked);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                RxDataCounter += data.Length;
                lbl_RxCounter.Text = "Rx: " + RxDataCounter.ToString();
            }
        }

        #region AppSettings
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

            if (ps.isPanelSettingsHiden == true) pnl_Settings.Width = 0;

            cb_RxAutoscroll.Checked = ps.rtb_Rx_AutoScroll;
            dataFormatPanel.DataFormat = (eDataFormat)ps.dfp_Rx_State;
            cb_Sort.Checked = ps.cb_Sort;
            nmn_ByteSort.Value = ps.nmn_ByteSort;
            cb_TxMacroSend.Checked = ps.cb_TxMacroSend;
            cb_Tx_Hex.Checked = ps.cb_Tx_Hex;
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
            ps.isPanelSettingsHiden = isPanelSettingsHiden;
            ps.isPanelMacroHiden = isPanelMacroHiden;
            ps.isBtnPannelPortSettingsHiden = dropDownPanelSettings.PanelOpened;
            ps.isBtnPanelReceivingHiden = dropDownPanelReceiving.PanelOpened;
            ps.isBtnPanelTransmitingHiden = dropDownPanelTransmiting.PanelOpened;
            ps.rtb_Rx_AutoScroll = cb_RxAutoscroll.Checked;
            ps.dfp_Rx_State = (byte)dataFormatPanel.DataFormat;
            ps.cb_Sort = cb_Sort.Checked;
            ps.nmn_ByteSort = nmn_ByteSort.Value;
            ps.cb_TxMacroSend = cb_TxMacroSend.Checked;
            ps.cb_Tx_Hex = cb_Tx_Hex.Checked;
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
            isPanelSettingsHiden = ps.isPanelSettingsHiden;
            isPanelMacroHiden = ps.isPanelMacroHiden;
            dropDownPanelSettings.PanelOpened = ps.isBtnPannelPortSettingsHiden;
            dropDownPanelReceiving.PanelOpened = ps.isBtnPanelReceivingHiden;
            dropDownPanelTransmiting.PanelOpened = ps.isBtnPanelTransmitingHiden;
        }
        #endregion

        private void tb_baudRateCustome_TextChanged(object sender, EventArgs e)   //prevent from entering chars instead numbers
        {
            if (TextHelper.IsNumberEntered(tb_baudRateCustome.Text) || "0" == tb_baudRateCustome.Text)
            {
                MessageBox.Show("Please enter only digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_baudRateCustome.Text = tb_baudRateCustome.Text.Remove(tb_baudRateCustome.Text.Length - 1);
                tb_baudRateCustome.Text = "1";
            }           
            else
            {
                try
                {
                    com_baudRateCustome = Convert.ToInt32(tb_baudRateCustome.Text);
                }
                catch (Exception) { }
            }   
        }

        #region RightPanel
        private void btn_Settings_Click(object sender, EventArgs e) => tmr_MenuSlide.Start();

        private void tmr_MenuSlide_Tick(object sender, EventArgs e)
        {
            if (isPanelSettingsHiden == true)
            {
                pnl_Settings.Width += 50;
                if (pnl_Settings.Width >= panelSettingsWidth)
                {
                    pnl_Settings.Width = panelSettingsWidth;
                    tmr_MenuSlide.Stop();
                    isPanelSettingsHiden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_Settings.Width -= 50;
                if (pnl_Settings.Width <= 0)
                {
                    pnl_Settings.Width = 0;
                    tmr_MenuSlide.Stop();
                    isPanelSettingsHiden = true;
                    this.Refresh();
                }
            }
        }

        private void btn_SerialConnect_Click(object sender, EventArgs e)
        {
            if (serialPortList.Keys.Count == 0)
            {
                SetTxtToStatusLable("CHOSE PORT FIRST", Color.Red);
                return;
            }

            if (isBtnOpenPress == false)
            {
                serClient.PortName = com_portName;
                serClient.PortBaudRate = com_baudRate;
                serClient.PortParity = com_parity;
                serClient.PortDataBits = com_dataBits;
                serClient.PortStopBits = com_stopBits;
                serClient.PortHandshake = com_handshake;
                
                serClient.OnSerialReceiving += new EventHandler<DataStreamEventArgs>(SerialReceiveHandler);
                serClient.OnSerialError += new EventHandler(SerialErrorHandler);

                if (serClient.Open() == true)
                {
                    SetTxtToStatusLable("SERIAL OPENED", Color.Aqua);
                    btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Connected_32px;
                    this.Text = "Terrarium " + (string)cmb_SerialPortList.SelectedItem;

                    cmb_SerialPortList.Enabled = false;
                    btn_SerialConnect.Enabled = true;
                }
                else
                {
                    serClient.Close();
                    serClient.OnSerialReceiving -= SerialReceiveHandler;
                    serClient.OnSerialError -= SerialErrorHandler;

                    SetTxtToStatusLable("SERIAL ERROR", Color.Red);
                    cmb_SerialPortList.Enabled = true;
                    btn_SerialConnect.Enabled = true;
                    isBtnOpenPress = false;
                    return;
                }
            }
            else
            {
                serClient.Close();
                serClient.OnSerialReceiving -= SerialReceiveHandler;
                serClient.OnSerialError -= SerialErrorHandler;
                SetTxtToStatusLable("SERIAL CLOSED", Color.Aqua);
                btn_SerialConnect.Image = Terrarium.Properties.Resources.icons8_Disconnected_32px;
                this.Text = "Terrarium ";
                cmb_SerialPortList.Enabled = true;
                btn_SerialConnect.Enabled = true;
            }
            isBtnOpenPress ^= true;
        }
        #endregion

        private void btn_CleanTxField_Click(object sender, EventArgs e)
        {
            rtb_Tx.Clear();
            macroPannel.tb_Tx.Clear();
        }

        private void btn_CleanRxField_Click(object sender, EventArgs e)
        {
            nrtb_Rx.RichTextBox.Clear();
            TextHelper.ResetChunkCounter();
        }

        #region SerialPortScan
        //-----------------------------------------------------------------------------------------------

        private int SerialPortScan()
        {
            serialPortList.Clear();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");

            try
            {
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if ((queryObj["Caption"] != null) && queryObj["Caption"].ToString().Contains("(COM"))
                    {
                        string[] tmpPortName = queryObj["Caption"].ToString().Split('(', ')');
                        serialPortList[tmpPortName[1]] = tmpPortName[0];
                    }
                }
            }
            catch (ManagementException)
            {

            }

            serialPortList.Keys.Distinct().ToArray();
            var portNameList = serialPortList.Keys.ToList();
            portNameList.Sort();

            if (portNameList.Contains(com_portName))
            {
                cmb_SerialPortList.Items.Clear();
                foreach(string item in portNameList)
                {                    
                    cmb_SerialPortList.Items.Add(item);
                    cmb_SerialPortList.SelectedIndex = cmb_SerialPortList.Items.IndexOf(com_portName);
                }                
            }
            else
            {
                cmb_SerialPortList.Items.Clear();
                foreach (string item in portNameList)
                {
                    cmb_SerialPortList.Items.Add(item);
                    cmb_SerialPortList.SelectedIndex = 0;
                }
            }


            if (serialPortList.Keys.Count != 0)
            {
                lbl_PortInfo.Text = serialPortList[(string)cmb_SerialPortList.SelectedItem];
            }
            
            com_portName = (string)cmb_SerialPortList.SelectedItem;
            return serialPortList.Keys.Count;
        }

        private void btn_SerialPortRefresh_Click(object sender, EventArgs e)
        {
            if (serClient.IsOpen() == false)
            {
                int portCount = SerialPortScan();
                if (portCount == 0) SetTxtToStatusLable("NO PORTS FOUND", Color.WhiteSmoke);
                else SetTxtToStatusLable("FOUND PORTS " + portCount, Color.WhiteSmoke);
            }
        }

        private void cmb_SerialPortList_Hover(object sender, HoverEventArgs e)
        {          
            var index = ((FlattenCombo)sender).Items[e.itemIndex].ToString();
            lbl_PortInfo.Text = serialPortList[index];
        }

        private void cmb_SerialPortList_DropDownClosed(object sender, EventArgs e)
        {
            if (cmb_SerialPortList.SelectedItem != null)
            {
              lbl_PortInfo.Text = serialPortList[(string)cmb_SerialPortList.SelectedItem];
            }
        }

        #endregion
        //-----------------------------------------------------------------------------------------------
        delegate void SetTextStatusLableCallback(string text, Color color);

        public void SetTxtToStatusLable(string data, Color color)
        {
            if (lbl_Status.InvokeRequired)
            {
                SetTextStatusLableCallback d = new SetTextStatusLableCallback(SetTxtToStatusLable);
                this.Invoke(d, new object[] { data, color });
            }
            else
            {
                lbl_Status.ForeColor = color;
                lbl_Status.Text = data;
            }
        }


       

        private void rtb_Tx_KeyPress(object sender, KeyPressEventArgs e)  //used for greping chars from rtb_Tx
        {
            char c = e.KeyChar;

            byte[] buff = new byte[1];
            buff[0] = Convert.ToByte(c);
            if (serClient != null && serClient.IsOpen() == true)
            {
                serClient.Transmit(buff);
                TxDataCounter += buff.Length;
                lbl_TxCounter.Text = "Tx: " + TxDataCounter.ToString();
            }
        }

        private void btn_SerialSend_Click(object sender, EventArgs e) => SerialSendHelper(macroPannel.tb_Tx.Text, cb_Tx_Hex.Checked);


        public void SerialSendHelper(string tbData, bool cbHex)
        {
            if (serClient.IsOpen() == true)
            {
                byte[] buff;
                if (cbHex == true)
                {
                    if (TextHelper.IsHexEntered(tbData))
                    {
                        MessageBox.Show("Please enter only numbers in HEX format XX", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    buff = TextHelper.StringToHex(tbData);
                }
                else
                {
                    buff = Encoding.UTF8.GetBytes(tbData);
                }
                serClient.Transmit(buff);

                TxDataCounter += buff.Length;
                lbl_TxCounter.Text = "Tx: " + TxDataCounter.ToString();
            }
            else
            {
                SetTxtToStatusLable("OPEN PORT FIRST", Color.Red);
            }
        }


        private void rtb_Rx_TextChanged(object sender, EventArgs e)
        {
            //rtb_Rx.SelectionStart = rtb_Rx.Text.Length;
            //rtb_Rx.ScrollToCaret();
        }

        private void lbl_RxCounter_DoubleClick(object sender, EventArgs e)
        {
            RxDataCounter = 0;
            lbl_RxCounter.Text = "Rx: " + RxDataCounter;
        }

        private void lbl_TxCounter_DoubleClick(object sender, EventArgs e)
        {
            TxDataCounter = 0;
            lbl_TxCounter.Text = "Tx: " + TxDataCounter;
        }

        private void cb_LinesNum_CheckedChanged(object sender, EventArgs e)
        {
            nrtb_Rx.NumStripVisible ^= true;
        }

        private void cb_Sort_CheckedChanged(object sender, EventArgs e)
        {
            nmn_ByteSort.Enabled ^= true;
        }

        private void cb_TxMacroSend_CheckedChanged(object sender, EventArgs e)
        {
            macroPannel.VisibleMacroButtons ^= true;
            if (macroPannel.VisibleMacroButtons == true)
            {
                tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[2].Height = 25F;
            }
            else
            {
                tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[2].Height = 100F;
            }
        }

        private void cmb_SerialPortList_SelectedValueChanged(object sender, EventArgs e)
        {
            com_portName = (string)cmb_SerialPortList.SelectedItem;
        }

        #region MacroPanelWizard
        private void btn_MacroPanelWizard_Click(object sender, EventArgs e) => macroWizard.Show();

        private void btn_m1_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP1_Text, macroWizard.MP1_HexMode);
        private void btn_m2_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP2_Text, macroWizard.MP2_HexMode);
        private void btn_m3_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP3_Text, macroWizard.MP3_HexMode);
        private void btn_m4_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP4_Text, macroWizard.MP4_HexMode);
        private void btn_m5_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP5_Text, macroWizard.MP5_HexMode);
        private void btn_m6_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP6_Text, macroWizard.MP6_HexMode);
        private void btn_m7_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP7_Text, macroWizard.MP7_HexMode);
        private void btn_m8_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP8_Text, macroWizard.MP8_HexMode);
        private void btn_m9_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP9_Text, macroWizard.MP9_HexMode);
        private void btn_m10_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP10_Text, macroWizard.MP10_HexMode);
        private void btn_m11_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP11_Text, macroWizard.MP11_HexMode);
        private void btn_m12_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP12_Text, macroWizard.MP12_HexMode);
        private void btn_m13_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP13_Text, macroWizard.MP13_HexMode);
        private void btn_m14_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP14_Text, macroWizard.MP14_HexMode);
        private void btn_m15_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP15_Text, macroWizard.MP15_HexMode);
        private void btn_m16_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP16_Text, macroWizard.MP16_HexMode);
        private void btn_m17_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP17_Text, macroWizard.MP17_HexMode);
        private void btn_m18_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP18_Text, macroWizard.MP18_HexMode);
        private void btn_m19_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP19_Text, macroWizard.MP19_HexMode);
        private void btn_m20_Click(object sender, EventArgs e) => SerialSendHelper(macroWizard.MP20_Text, macroWizard.MP20_HexMode);

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Terrarium macro(*.tmc)|*.tmc|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
                
            string[] text = new string[20];
            text[0] = macroWizard.MP1_Text;
            text[1] = macroWizard.MP2_Text;
            text[2] = macroWizard.MP3_Text;
            text[3] = macroWizard.MP4_Text;
            text[4] = macroWizard.MP5_Text;
            text[5] = macroWizard.MP6_Text;
            text[6] = macroWizard.MP7_Text;
            text[7] = macroWizard.MP8_Text;
            text[8] = macroWizard.MP9_Text;
            text[9] = macroWizard.MP10_Text;
            text[10] = macroWizard.MP11_Text;
            text[11] = macroWizard.MP12_Text;
            text[12] = macroWizard.MP13_Text;
            text[13] = macroWizard.MP14_Text;
            text[14] = macroWizard.MP15_Text;
            text[15] = macroWizard.MP16_Text;
            text[16] = macroWizard.MP17_Text;
            text[17] = macroWizard.MP18_Text;
            text[18] = macroWizard.MP19_Text;
            text[19] = macroWizard.MP20_Text;
            macroWizardConf.Config.FieldData = text;

            string[] buttonText = new string[20];
            buttonText[0] = macroWizard.MP1_ButtonText;
            buttonText[1] = macroWizard.MP2_ButtonText;
            buttonText[2] = macroWizard.MP3_ButtonText;
            buttonText[3] = macroWizard.MP4_ButtonText;
            buttonText[4] = macroWizard.MP5_ButtonText;
            buttonText[5] = macroWizard.MP6_ButtonText;
            buttonText[6] = macroWizard.MP7_ButtonText;
            buttonText[7] = macroWizard.MP8_ButtonText;
            buttonText[8] = macroWizard.MP9_ButtonText;
            buttonText[9] = macroWizard.MP10_ButtonText;
            buttonText[10] = macroWizard.MP11_ButtonText;
            buttonText[11] = macroWizard.MP12_ButtonText;
            buttonText[12] = macroWizard.MP13_ButtonText;
            buttonText[13] = macroWizard.MP14_ButtonText;
            buttonText[14] = macroWizard.MP15_ButtonText;
            buttonText[15] = macroWizard.MP16_ButtonText;
            buttonText[16] = macroWizard.MP17_ButtonText;
            buttonText[17] = macroWizard.MP18_ButtonText;
            buttonText[18] = macroWizard.MP19_ButtonText;
            buttonText[19] = macroWizard.MP20_ButtonText;
            macroWizardConf.Config.ButtonText = buttonText;

            bool[] hexMode = new bool[20];
            hexMode[0] = macroWizard.MP1_HexMode;
            hexMode[1] = macroWizard.MP2_HexMode;
            hexMode[2] = macroWizard.MP3_HexMode;
            hexMode[3] = macroWizard.MP4_HexMode;
            hexMode[4] = macroWizard.MP5_HexMode;
            hexMode[5] = macroWizard.MP6_HexMode;
            hexMode[6] = macroWizard.MP7_HexMode;
            hexMode[7] = macroWizard.MP8_HexMode;
            hexMode[8] = macroWizard.MP9_HexMode;
            hexMode[9] = macroWizard.MP10_HexMode;
            hexMode[10] = macroWizard.MP11_HexMode;
            hexMode[11] = macroWizard.MP12_HexMode;
            hexMode[12] = macroWizard.MP13_HexMode;
            hexMode[13] = macroWizard.MP14_HexMode;
            hexMode[14] = macroWizard.MP15_HexMode;
            hexMode[15] = macroWizard.MP16_HexMode;
            hexMode[16] = macroWizard.MP17_HexMode;
            hexMode[17] = macroWizard.MP18_HexMode;
            hexMode[18] = macroWizard.MP19_HexMode;
            hexMode[19] = macroWizard.MP20_HexMode;
            macroWizardConf.Config.HexMode = hexMode;

            macroWizard.ConfigFileLable = macroWizardConf.GetFileName(saveFileDialog.FileName);
            macroWizardConf.SaveConfig(saveFileDialog.FileName);
            ps.macroPanelConfFileLocation = saveFileDialog.FileName;
            macroWizardConf.GetFileName(saveFileDialog.FileName);

        }

        private void macroWizardFillConfigs()
        {
            string[] text = new string[20];
            text = macroWizardConf.Config.FieldData;
            macroWizard.MP1_Text = text[0];
            macroWizard.MP2_Text = text[1];
            macroWizard.MP3_Text = text[2];
            macroWizard.MP4_Text = text[3];
            macroWizard.MP5_Text = text[4];
            macroWizard.MP6_Text = text[5];
            macroWizard.MP7_Text = text[6];
            macroWizard.MP8_Text = text[7];
            macroWizard.MP9_Text = text[8];
            macroWizard.MP10_Text = text[9];
            macroWizard.MP11_Text = text[10];
            macroWizard.MP12_Text = text[11];
            macroWizard.MP13_Text = text[12];
            macroWizard.MP14_Text = text[13];
            macroWizard.MP15_Text = text[14];
            macroWizard.MP16_Text = text[15];
            macroWizard.MP17_Text = text[16];
            macroWizard.MP18_Text = text[17];
            macroWizard.MP19_Text = text[18];
            macroWizard.MP20_Text = text[19];

            string[] buttonText = new string[20];
            buttonText = macroWizardConf.Config.ButtonText;
            macroPannel.btn_m1.Text = macroWizard.MP1_ButtonText = buttonText[0];
            macroPannel.btn_m2.Text = macroWizard.MP2_ButtonText = buttonText[1];
            macroPannel.btn_m3.Text = macroWizard.MP3_ButtonText = buttonText[2];
            macroPannel.btn_m4.Text = macroWizard.MP4_ButtonText = buttonText[3];
            macroPannel.btn_m5.Text = macroWizard.MP5_ButtonText = buttonText[4];
            macroPannel.btn_m6.Text = macroWizard.MP6_ButtonText = buttonText[5];
            macroPannel.btn_m7.Text = macroWizard.MP7_ButtonText = buttonText[6];
            macroPannel.btn_m8.Text = macroWizard.MP8_ButtonText = buttonText[7];
            macroPannel.btn_m9.Text = macroWizard.MP9_ButtonText = buttonText[8];
            macroPannel.btn_m10.Text = macroWizard.MP10_ButtonText = buttonText[9];
            macroPannel.btn_m11.Text = macroWizard.MP11_ButtonText = buttonText[10];
            macroPannel.btn_m12.Text = macroWizard.MP12_ButtonText = buttonText[11];
            macroPannel.btn_m13.Text = macroWizard.MP13_ButtonText = buttonText[12];
            macroPannel.btn_m14.Text = macroWizard.MP14_ButtonText = buttonText[13];
            macroPannel.btn_m15.Text = macroWizard.MP15_ButtonText = buttonText[14];
            macroPannel.btn_m16.Text = macroWizard.MP16_ButtonText = buttonText[15];
            macroPannel.btn_m17.Text = macroWizard.MP17_ButtonText = buttonText[16];
            macroPannel.btn_m18.Text = macroWizard.MP18_ButtonText = buttonText[17];
            macroPannel.btn_m19.Text = macroWizard.MP19_ButtonText = buttonText[18];
            macroPannel.btn_m20.Text = macroWizard.MP20_ButtonText = buttonText[19];

            bool[] hexMode = new bool[20];
            hexMode = macroWizardConf.Config.HexMode;
            macroWizard.MP1_HexMode = hexMode[0];
            macroWizard.MP2_HexMode = hexMode[1];
            macroWizard.MP3_HexMode = hexMode[2];
            macroWizard.MP4_HexMode = hexMode[3];
            macroWizard.MP5_HexMode = hexMode[4];
            macroWizard.MP6_HexMode = hexMode[5];
            macroWizard.MP7_HexMode = hexMode[6];
            macroWizard.MP8_HexMode = hexMode[7];
            macroWizard.MP9_HexMode = hexMode[8];
            macroWizard.MP10_HexMode = hexMode[9];
            macroWizard.MP11_HexMode = hexMode[10];
            macroWizard.MP12_HexMode = hexMode[11];
            macroWizard.MP13_HexMode = hexMode[12];
            macroWizard.MP14_HexMode = hexMode[13];
            macroWizard.MP15_HexMode = hexMode[14];
            macroWizard.MP16_HexMode = hexMode[15];
            macroWizard.MP17_HexMode = hexMode[16];
            macroWizard.MP18_HexMode = hexMode[17];
            macroWizard.MP19_HexMode = hexMode[18];
            macroWizard.MP20_HexMode = hexMode[19];

            macroWizard.ConfigFileLable = macroWizardConf.GetFileName(ps.macroPanelConfFileLocation);
        }
        #endregion

        private void btn_LoadConfig_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Terrarium macro(*.tmc)|*.tmc|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            ps.macroPanelConfFileLocation = openFileDialog.FileName;
            ps.Save();

            macroWizardConf.LoadConfig(ps.macroPanelConfFileLocation);
            macroWizard.ConfigFileLable = macroWizardConf.GetFileName(ps.macroPanelConfFileLocation);
            macroWizardFillConfigs();
        }

        private void btn_m1_TextChange(object sender, EventArgs e) => macroPannel.btn_m1.Text = macroWizard.MP1_ButtonText;
        private void btn_m2_TextChange(object sender, EventArgs e) => macroPannel.btn_m2.Text = macroWizard.MP2_ButtonText;
        private void btn_m3_TextChange(object sender, EventArgs e) => macroPannel.btn_m3.Text = macroWizard.MP3_ButtonText;
        private void btn_m4_TextChange(object sender, EventArgs e) => macroPannel.btn_m4.Text = macroWizard.MP4_ButtonText;
        private void btn_m5_TextChange(object sender, EventArgs e) => macroPannel.btn_m5.Text = macroWizard.MP5_ButtonText;
        private void btn_m6_TextChange(object sender, EventArgs e) => macroPannel.btn_m6.Text = macroWizard.MP6_ButtonText;
        private void btn_m7_TextChange(object sender, EventArgs e) => macroPannel.btn_m7.Text = macroWizard.MP7_ButtonText;
        private void btn_m8_TextChange(object sender, EventArgs e) => macroPannel.btn_m8.Text = macroWizard.MP8_ButtonText;
        private void btn_m9_TextChange(object sender, EventArgs e) => macroPannel.btn_m9.Text = macroWizard.MP9_ButtonText;
        private void btn_m10_TextChange(object sender, EventArgs e) => macroPannel.btn_m10.Text = macroWizard.MP10_ButtonText;
        private void btn_m11_TextChange(object sender, EventArgs e) => macroPannel.btn_m11.Text = macroWizard.MP11_ButtonText;
        private void btn_m12_TextChange(object sender, EventArgs e) => macroPannel.btn_m12.Text = macroWizard.MP12_ButtonText;
        private void btn_m13_TextChange(object sender, EventArgs e) => macroPannel.btn_m13.Text = macroWizard.MP13_ButtonText;
        private void btn_m14_TextChange(object sender, EventArgs e) => macroPannel.btn_m14.Text = macroWizard.MP14_ButtonText;
        private void btn_m15_TextChange(object sender, EventArgs e) => macroPannel.btn_m15.Text = macroWizard.MP15_ButtonText;
        private void btn_m16_TextChange(object sender, EventArgs e) => macroPannel.btn_m16.Text = macroWizard.MP16_ButtonText;
        private void btn_m17_TextChange(object sender, EventArgs e) => macroPannel.btn_m17.Text = macroWizard.MP17_ButtonText;
        private void btn_m18_TextChange(object sender, EventArgs e) => macroPannel.btn_m18.Text = macroWizard.MP18_ButtonText;
        private void btn_m19_TextChange(object sender, EventArgs e) => macroPannel.btn_m19.Text = macroWizard.MP19_ButtonText;
        private void btn_m20_TextChange(object sender, EventArgs e) => macroPannel.btn_m20.Text = macroWizard.MP20_ButtonText;



        private void btn_PanelPortSettings_Click(object sender, EventArgs e)
        {
            if (dropDownPanelSettings.PanelOpened == false)
            {
                mainLayoutPanelSettings.RowStyles[3].Height = 0F;               
            }
            else
            {
                mainLayoutPanelSettings.RowStyles[3].Height = 316F;
            }
            pnl_PortSettings.Size = new Size(225, (int)mainLayoutPanelSettings.RowStyles[3].Height);       
        }

        private void btn_PanelReceiving_Click(object sender, EventArgs e)
        {
            if (dropDownPanelReceiving.PanelOpened == false)
            {
                mainLayoutPanelSettings.RowStyles[5].Height = 0F;            
            }
            else
            {
                mainLayoutPanelSettings.RowStyles[5].Height = 100F;
            }
            pnl_Receiving.Size = new Size(225, (int)mainLayoutPanelSettings.RowStyles[5].Height);

        }

        private void btn_PanelTransmiting_Click(object sender, EventArgs e)
        {
            if (dropDownPanelTransmiting.PanelOpened == false)
            {
                mainLayoutPanelSettings.RowStyles[7].Height = 0F;
            }
            else
            {
                mainLayoutPanelSettings.RowStyles[7].Height = 130F;               
            }
            pnl_Transmiting.Size = new Size(225, (int)mainLayoutPanelSettings.RowStyles[7].Height);
        }

        #region RightMouseClickMenu
        private void menuFind_Click(object sender, EventArgs e)
        {
            if (Form.ActiveForm == findForm && findForm.IsDisposed)            // second run or form on not active
            {
                if (nrtb_Rx.RichTextBox.SelectedText != "")
                {
                    findForm.SearchData = nrtb_Rx.RichTextBox.SelectedText;
                }

                findForm.Focus();
            }
            else if (Form.ActiveForm != findForm)  // first run of this form
            {
                if (findForm.IsDisposed)
                {
                    findForm = new FindForm();
                    findForm.BtnFindEventHandler += new EventHandler(btnFind_Click);
                }

                findForm.DataFormat = dataFormatPanel.DataFormat;

                if (nrtb_Rx.RichTextBox.SelectedText != "")
                {
                    findForm.SearchData = nrtb_Rx.RichTextBox.SelectedText;
                }

                findForm.Show(this);                
            }                     
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String[] tmp = new String[] { findForm.SearchData };         
            TextHelper.HighlightWords(nrtb_Rx, tmp);
        }
        #endregion
    }
}



