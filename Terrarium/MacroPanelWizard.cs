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
        public event EventHandler BtnM1Click;
        public event EventHandler BtnM2Click;
        public event EventHandler BtnM3Click;
        public event EventHandler BtnM4Click;
        public event EventHandler BtnM5Click;
        public event EventHandler BtnM6Click;
        public event EventHandler BtnM7Click;
        public event EventHandler BtnM8Click;
        public event EventHandler BtnM9Click;
        public event EventHandler BtnM10Click;
        public event EventHandler BtnM11Click;
        public event EventHandler BtnM12Click;
        public event EventHandler BtnM13Click;
        public event EventHandler BtnM14Click;
        public event EventHandler BtnM15Click;
        public event EventHandler BtnM16Click;
        public event EventHandler BtnM17Click;
        public event EventHandler BtnM18Click;
        public event EventHandler BtnM19Click;
        public event EventHandler BtnM20Click;
        public event EventHandler BtnSaveConfigClick;
        public event EventHandler BtnLoadConfigClick;

        public event EventHandler BtnM1TextChange;
        public event EventHandler BtnM2TextChange;
        public event EventHandler BtnM3TextChange;
        public event EventHandler BtnM4TextChange;
        public event EventHandler BtnM5TextChange;
        public event EventHandler BtnM6TextChange;
        public event EventHandler BtnM7TextChange;
        public event EventHandler BtnM8TextChange;
        public event EventHandler BtnM9TextChange;
        public event EventHandler BtnM10TextChange;
        public event EventHandler BtnM11TextChange;
        public event EventHandler BtnM12TextChange;
        public event EventHandler BtnM13TextChange;
        public event EventHandler BtnM14TextChange;
        public event EventHandler BtnM15TextChange;
        public event EventHandler BtnM16TextChange;
        public event EventHandler BtnM17TextChange;
        public event EventHandler BtnM18TextChange;
        public event EventHandler BtnM19TextChange;
        public event EventHandler BtnM20TextChange;

        public MacroPanelWizard()
        {
            InitializeComponent();
            macroField1.btnClickEvent += new EventHandler(btn_m1_Click);
            macroField1.btnTextChangeEvent += new EventHandler(btn_m1_TextChanged);

            macroField2.btnClickEvent += new EventHandler(btn_m2_Click);
            macroField2.btnTextChangeEvent += new EventHandler(btn_m2_TextChanged);

            macroField3.btnClickEvent += new EventHandler(btn_m3_Click);
            macroField3.btnTextChangeEvent += new EventHandler(btn_m3_TextChanged);

            macroField4.btnClickEvent += new EventHandler(btn_m4_Click);
            macroField4.btnTextChangeEvent += new EventHandler(btn_m4_TextChanged);

            macroField5.btnClickEvent += new EventHandler(btn_m5_Click);
            macroField5.btnTextChangeEvent += new EventHandler(btn_m5_TextChanged);

            macroField6.btnClickEvent += new EventHandler(btn_m6_Click);
            macroField6.btnTextChangeEvent += new EventHandler(btn_m6_TextChanged);

            macroField7.btnClickEvent += new EventHandler(btn_m7_Click);
            macroField7.btnTextChangeEvent += new EventHandler(btn_m7_TextChanged);

            macroField8.btnClickEvent += new EventHandler(btn_m8_Click);
            macroField8.btnTextChangeEvent += new EventHandler(btn_m8_TextChanged);

            macroField9.btnClickEvent += new EventHandler(btn_m9_Click);
            macroField9.btnTextChangeEvent += new EventHandler(btn_m9_TextChanged);

            macroField10.btnClickEvent += new EventHandler(btn_m10_Click);
            macroField10.btnTextChangeEvent += new EventHandler(btn_m10_TextChanged);

            macroField11.btnClickEvent += new EventHandler(btn_m11_Click);
            macroField11.btnTextChangeEvent += new EventHandler(btn_m11_TextChanged);

            macroField12.btnClickEvent += new EventHandler(btn_m12_Click);
            macroField12.btnTextChangeEvent += new EventHandler(btn_m12_TextChanged);

            macroField13.btnClickEvent += new EventHandler(btn_m13_Click);
            macroField13.btnTextChangeEvent += new EventHandler(btn_m13_TextChanged);

            macroField14.btnClickEvent += new EventHandler(btn_m14_Click);
            macroField14.btnTextChangeEvent += new EventHandler(btn_m14_TextChanged);

            macroField15.btnClickEvent += new EventHandler(btn_m15_Click);
            macroField15.btnTextChangeEvent += new EventHandler(btn_m15_TextChanged);

            macroField16.btnClickEvent += new EventHandler(btn_m16_Click);
            macroField16.btnTextChangeEvent += new EventHandler(btn_m16_TextChanged);

            macroField17.btnClickEvent += new EventHandler(btn_m17_Click);
            macroField17.btnTextChangeEvent += new EventHandler(btn_m17_TextChanged);

            macroField18.btnClickEvent += new EventHandler(btn_m18_Click);
            macroField18.btnTextChangeEvent += new EventHandler(btn_m18_TextChanged);

            macroField19.btnClickEvent += new EventHandler(btn_m19_Click);
            macroField19.btnTextChangeEvent += new EventHandler(btn_m19_TextChanged);

            macroField20.btnClickEvent += new EventHandler(btn_m20_Click);
            macroField20.btnTextChangeEvent += new EventHandler(btn_m20_TextChanged);

            btn_SaveSettings.Click += new System.EventHandler(btn_SaveSettings_Click);
            btn_LoadSettings.Click += new System.EventHandler(btn_LoadSettings_Click);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)   // hide form but not close it
        {
            if (e.CloseReason == CloseReason.WindowsShutDown
                || e.CloseReason == CloseReason.ApplicationExitCall
                || e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }
            e.Cancel = true;

            this.Hide();
        }

        #region Geters Setters
        public string MP1_Text { get => macroField1.tb_MacroData.Text; set => macroField1.tb_MacroData.Text = value; }
        public bool MP1_HexMode { get => macroField1.HexMode; set => macroField1.HexMode = value; }
        public decimal MP1_RepeatTime { get => macroField1.RepeatTimeValue; set => macroField1.RepeatTimeValue = value; }
        public bool MP1_Repeat { get => macroField1.RepeatActive; set => macroField1.RepeatActive = value; }
        public string MP1_ButtonText { get => macroField1.ButtonText; set => macroField1.ButtonText = value; }

        public string MP2_Text { get => macroField2.tb_MacroData.Text; set => macroField2.tb_MacroData.Text = value; }
        public bool MP2_HexMode { get => macroField2.HexMode; set => macroField2.HexMode = value; }
        public decimal MP2_RepeatTime { get => macroField2.RepeatTimeValue; set => macroField2.RepeatTimeValue = value; }
        public bool MP2_Repeat { get => macroField2.RepeatActive; set => macroField2.RepeatActive = value; }
        public string MP2_ButtonText { get => macroField2.ButtonText; set => macroField2.ButtonText = value; }

        public string MP3_Text { get => macroField3.tb_MacroData.Text; set => macroField3.tb_MacroData.Text = value; }
        public bool MP3_HexMode { get => macroField3.HexMode; set => macroField3.HexMode = value; }
        public decimal MP3_RepeatTime { get => macroField3.RepeatTimeValue; set => macroField3.RepeatTimeValue = value; }
        public bool MP3_Repeat { get => macroField3.RepeatActive; set => macroField3.RepeatActive = value; }
        public string MP3_ButtonText { get => macroField3.ButtonText; set => macroField3.ButtonText = value; }

        public string MP4_Text { get => macroField4.tb_MacroData.Text; set => macroField4.tb_MacroData.Text = value; }
        public bool MP4_HexMode { get => macroField4.HexMode; set => macroField4.HexMode = value; }
        public decimal MP4_RepeatTime { get => macroField4.RepeatTimeValue; set => macroField4.RepeatTimeValue = value; }
        public bool MP4_Repeat { get => macroField4.RepeatActive; set => macroField4.RepeatActive = value; }
        public string MP4_ButtonText { get => macroField4.ButtonText; set => macroField4.ButtonText = value; }

        public string MP5_Text { get => macroField5.tb_MacroData.Text; set => macroField5.tb_MacroData.Text = value; }
        public bool MP5_HexMode { get => macroField5.HexMode; set => macroField5.HexMode = value; }
        public decimal MP5_RepeatTime { get => macroField5.RepeatTimeValue; set => macroField5.RepeatTimeValue = value; }
        public bool MP5_Repeat { get => macroField5.RepeatActive; set => macroField5.RepeatActive = value; }
        public string MP5_ButtonText { get => macroField5.ButtonText; set => macroField5.ButtonText = value; }

        public string MP6_Text { get => macroField6.tb_MacroData.Text; set => macroField6.tb_MacroData.Text = value; }
        public bool MP6_HexMode { get => macroField6.HexMode; set => macroField6.HexMode = value; }
        public decimal MP6_RepeatTime { get => macroField6.RepeatTimeValue; set => macroField6.RepeatTimeValue = value; }
        public bool MP6_Repeat { get => macroField6.RepeatActive; set => macroField6.RepeatActive = value; }
        public string MP6_ButtonText { get => macroField6.ButtonText; set => macroField6.ButtonText = value; }

        public string MP7_Text { get => macroField7.tb_MacroData.Text; set => macroField7.tb_MacroData.Text = value; }
        public bool MP7_HexMode { get => macroField7.HexMode; set => macroField7.HexMode = value; }
        public decimal MP7_RepeatTime { get => macroField7.RepeatTimeValue; set => macroField7.RepeatTimeValue = value; }
        public bool MP7_Repeat { get => macroField7.RepeatActive; set => macroField7.RepeatActive = value; }
        public string MP7_ButtonText { get => macroField7.ButtonText; set => macroField7.ButtonText = value; }

        public string MP8_Text { get => macroField8.tb_MacroData.Text; set => macroField8.tb_MacroData.Text = value; }
        public bool MP8_HexMode { get => macroField8.HexMode; set => macroField8.HexMode = value; }
        public decimal MP8_RepeatTime { get => macroField8.RepeatTimeValue; set => macroField8.RepeatTimeValue = value; }
        public bool MP8_Repeat { get => macroField8.RepeatActive; set => macroField8.RepeatActive = value; }
        public string MP8_ButtonText { get => macroField8.ButtonText; set => macroField8.ButtonText = value; }

        public string MP9_Text { get => macroField9.tb_MacroData.Text; set => macroField9.tb_MacroData.Text = value; }
        public bool MP9_HexMode { get => macroField9.HexMode; set => macroField9.HexMode = value; }
        public decimal MP9_RepeatTime { get => macroField9.RepeatTimeValue; set => macroField9.RepeatTimeValue = value; }
        public bool MP9_Repeat { get => macroField9.RepeatActive; set => macroField9.RepeatActive = value; }
        public string MP9_ButtonText { get => macroField9.ButtonText; set => macroField9.ButtonText = value; }

        public string MP10_Text { get => macroField10.tb_MacroData.Text; set => macroField10.tb_MacroData.Text = value; }
        public bool MP10_HexMode { get => macroField10.HexMode; set => macroField10.HexMode = value; }
        public decimal MP10_RepeatTime { get => macroField10.RepeatTimeValue; set => macroField10.RepeatTimeValue = value; }
        public bool MP10_Repeat { get => macroField10.RepeatActive; set => macroField10.RepeatActive = value; }
        public string MP10_ButtonText { get => macroField10.ButtonText; set => macroField10.ButtonText = value; }

        public string MP11_Text { get => macroField11.tb_MacroData.Text; set => macroField11.tb_MacroData.Text = value; }
        public bool MP11_HexMode { get => macroField11.HexMode; set => macroField11.HexMode = value; }
        public decimal MP11_RepeatTime { get => macroField11.RepeatTimeValue; set => macroField11.RepeatTimeValue = value; }
        public bool MP11_Repeat { get => macroField11.RepeatActive; set => macroField11.RepeatActive = value; }
        public string MP11_ButtonText { get => macroField11.ButtonText; set => macroField11.ButtonText = value; }

        public string MP12_Text { get => macroField12.tb_MacroData.Text; set => macroField12.tb_MacroData.Text = value; }
        public bool MP12_HexMode { get => macroField12.HexMode; set => macroField12.HexMode = value; }
        public decimal MP12_RepeatTime { get => macroField12.RepeatTimeValue; set => macroField12.RepeatTimeValue = value; }
        public bool MP12_Repeat { get => macroField12.RepeatActive; set => macroField12.RepeatActive = value; }
        public string MP12_ButtonText { get => macroField12.ButtonText; set => macroField12.ButtonText = value; }

        public string MP13_Text { get => macroField13.tb_MacroData.Text; set => macroField13.tb_MacroData.Text = value; }
        public bool MP13_HexMode { get => macroField13.HexMode; set => macroField13.HexMode = value; }
        public decimal MP13_RepeatTime { get => macroField13.RepeatTimeValue; set => macroField13.RepeatTimeValue = value; }
        public bool MP13_Repeat { get => macroField13.RepeatActive; set => macroField13.RepeatActive = value; }
        public string MP13_ButtonText { get => macroField13.ButtonText; set => macroField13.ButtonText = value; }

        public string MP14_Text { get => macroField14.tb_MacroData.Text; set => macroField14.tb_MacroData.Text = value; }
        public bool MP14_HexMode { get => macroField14.HexMode; set => macroField14.HexMode = value; }
        public decimal MP14_RepeatTime { get => macroField14.RepeatTimeValue; set => macroField14.RepeatTimeValue = value; }
        public bool MP14_Repeat { get => macroField14.RepeatActive; set => macroField14.RepeatActive = value; }
        public string MP14_ButtonText { get => macroField14.ButtonText; set => macroField14.ButtonText = value; }

        public string MP15_Text { get => macroField15.tb_MacroData.Text; set => macroField15.tb_MacroData.Text = value; }
        public bool MP15_HexMode { get => macroField15.HexMode; set => macroField15.HexMode = value; }
        public decimal MP15_RepeatTime { get => macroField15.RepeatTimeValue; set => macroField15.RepeatTimeValue = value; }
        public bool MP15_Repeat { get => macroField15.RepeatActive; set => macroField15.RepeatActive = value; }
        public string MP15_ButtonText { get => macroField15.ButtonText; set => macroField15.ButtonText = value; }

        public string MP16_Text { get => macroField16.tb_MacroData.Text; set => macroField16.tb_MacroData.Text = value; }
        public bool MP16_HexMode { get => macroField16.HexMode; set => macroField16.HexMode = value; }
        public decimal MP16_RepeatTime { get => macroField16.RepeatTimeValue; set => macroField16.RepeatTimeValue = value; }
        public bool MP16_Repeat { get => macroField16.RepeatActive; set => macroField16.RepeatActive = value; }
        public string MP16_ButtonText { get => macroField16.ButtonText; set => macroField16.ButtonText = value; }

        public string MP17_Text { get => macroField17.tb_MacroData.Text; set => macroField17.tb_MacroData.Text = value; }
        public bool MP17_HexMode { get => macroField17.HexMode; set => macroField17.HexMode = value; }
        public decimal MP17_RepeatTime { get => macroField17.RepeatTimeValue; set => macroField17.RepeatTimeValue = value; }
        public bool MP17_Repeat { get => macroField17.RepeatActive; set => macroField17.RepeatActive = value; }
        public string MP17_ButtonText { get => macroField17.ButtonText; set => macroField17.ButtonText = value; }

        public string MP18_Text { get => macroField18.tb_MacroData.Text; set => macroField18.tb_MacroData.Text = value; }
        public bool MP18_HexMode { get => macroField18.HexMode; set => macroField18.HexMode = value; }
        public decimal MP18_RepeatTime { get => macroField18.RepeatTimeValue; set => macroField18.RepeatTimeValue = value; }
        public bool MP18_Repeat { get => macroField18.RepeatActive; set => macroField18.RepeatActive = value; }
        public string MP18_ButtonText { get => macroField18.ButtonText; set => macroField18.ButtonText = value; }

        public string MP19_Text { get => macroField19.tb_MacroData.Text; set => macroField19.tb_MacroData.Text = value; }
        public bool MP19_HexMode { get => macroField19.HexMode; set => macroField19.HexMode = value; }
        public decimal MP19_RepeatTime { get => macroField19.RepeatTimeValue; set => macroField19.RepeatTimeValue = value; }
        public bool MP19_Repeat { get => macroField19.RepeatActive; set => macroField19.RepeatActive = value; }
        public string MP19_ButtonText { get => macroField19.ButtonText; set => macroField19.ButtonText = value; }

        public string MP20_Text { get => macroField20.tb_MacroData.Text; set => macroField20.tb_MacroData.Text = value; }
        public bool MP20_HexMode { get => macroField20.HexMode; set => macroField20.HexMode = value; }
        public decimal MP20_RepeatTime { get => macroField20.RepeatTimeValue; set => macroField20.RepeatTimeValue = value; }
        public bool MP20_Repeat { get => macroField20.RepeatActive; set => macroField20.RepeatActive = value; }
        public string MP20_ButtonText { get => macroField20.ButtonText; set => macroField20.ButtonText = value; }

        public string ConfigFileLable{ get => lbl_FileName.Text; set => lbl_FileName.Text = value; }
            
        #endregion

        #region Functions
        private void btn_m1_Click(object sender, EventArgs e) => this.BtnM1Click?.Invoke(this, e);
        private void btn_m1_TextChanged(object sender, EventArgs e) => this.BtnM1TextChange?.Invoke(this, e);

        private void btn_m2_Click(object sender, EventArgs e) => this.BtnM2Click?.Invoke(this, e);
        private void btn_m2_TextChanged(object sender, EventArgs e) => this.BtnM2TextChange?.Invoke(this, e);

        private void btn_m3_Click(object sender, EventArgs e) => this.BtnM3Click?.Invoke(this, e);
        private void btn_m3_TextChanged(object sender, EventArgs e) => this.BtnM3TextChange?.Invoke(this, e);

        private void btn_m4_Click(object sender, EventArgs e) => this.BtnM4Click?.Invoke(this, e);
        private void btn_m4_TextChanged(object sender, EventArgs e) => this.BtnM4TextChange?.Invoke(this, e);

        private void btn_m5_Click(object sender, EventArgs e) => this.BtnM5Click?.Invoke(this, e);
        private void btn_m5_TextChanged(object sender, EventArgs e) => this.BtnM5TextChange?.Invoke(this, e);

        private void btn_m6_Click(object sender, EventArgs e) => this.BtnM6Click?.Invoke(this, e);
        private void btn_m6_TextChanged(object sender, EventArgs e) => this.BtnM6TextChange?.Invoke(this, e);

        private void btn_m7_Click(object sender, EventArgs e) => this.BtnM7Click?.Invoke(this, e);
        private void btn_m7_TextChanged(object sender, EventArgs e) => this.BtnM7TextChange?.Invoke(this, e);

        private void btn_m8_Click(object sender, EventArgs e) => this.BtnM8Click?.Invoke(this, e);
        private void btn_m8_TextChanged(object sender, EventArgs e) => this.BtnM8TextChange?.Invoke(this, e);

        private void btn_m9_Click(object sender, EventArgs e) => this.BtnM9Click?.Invoke(this, e);
        private void btn_m9_TextChanged(object sender, EventArgs e) => this.BtnM9TextChange?.Invoke(this, e);

        private void btn_m10_Click(object sender, EventArgs e) => this.BtnM10Click?.Invoke(this, e);
        private void btn_m10_TextChanged(object sender, EventArgs e) => this.BtnM10TextChange?.Invoke(this, e);

        private void btn_m11_Click(object sender, EventArgs e) => this.BtnM11Click?.Invoke(this, e);
        private void btn_m11_TextChanged(object sender, EventArgs e) => this.BtnM11TextChange?.Invoke(this, e);

        private void btn_m12_Click(object sender, EventArgs e) => this.BtnM12Click?.Invoke(this, e);
        private void btn_m12_TextChanged(object sender, EventArgs e) => this.BtnM12TextChange?.Invoke(this, e);

        private void btn_m13_Click(object sender, EventArgs e) => this.BtnM13Click?.Invoke(this, e);
        private void btn_m13_TextChanged(object sender, EventArgs e) => this.BtnM13TextChange?.Invoke(this, e);

        private void btn_m14_Click(object sender, EventArgs e) => this.BtnM14Click?.Invoke(this, e);
        private void btn_m14_TextChanged(object sender, EventArgs e) => this.BtnM14TextChange?.Invoke(this, e);

        private void btn_m15_Click(object sender, EventArgs e) => this.BtnM15Click?.Invoke(this, e);
        private void btn_m15_TextChanged(object sender, EventArgs e) => this.BtnM15TextChange?.Invoke(this, e);

        private void btn_m16_Click(object sender, EventArgs e) => this.BtnM16Click?.Invoke(this, e);
        private void btn_m16_TextChanged(object sender, EventArgs e) => this.BtnM16TextChange?.Invoke(this, e);

        private void btn_m17_Click(object sender, EventArgs e) => this.BtnM17Click?.Invoke(this, e);
        private void btn_m17_TextChanged(object sender, EventArgs e) => this.BtnM17TextChange?.Invoke(this, e);

        private void btn_m18_Click(object sender, EventArgs e) => this.BtnM18Click?.Invoke(this, e);
        private void btn_m18_TextChanged(object sender, EventArgs e) => this.BtnM18TextChange?.Invoke(this, e);

        private void btn_m19_Click(object sender, EventArgs e) => this.BtnM19Click?.Invoke(this, e);
        private void btn_m19_TextChanged(object sender, EventArgs e) => this.BtnM19TextChange?.Invoke(this, e);

        private void btn_m20_Click(object sender, EventArgs e) => this.BtnM20Click?.Invoke(this, e);
        private void btn_m20_TextChanged(object sender, EventArgs e) => this.BtnM20TextChange?.Invoke(this, e);

        private void btn_SaveSettings_Click(object sender, EventArgs e) => this.BtnSaveConfigClick?.Invoke(this, e);
        private void btn_LoadSettings_Click(object sender, EventArgs e) => this.BtnLoadConfigClick?.Invoke(this, e);

        #endregion
    }
}
