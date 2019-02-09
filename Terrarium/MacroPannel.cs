using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terrarium
{
    public partial class MacroPannel : UserControl
    {
        private bool VisibleBotomPanel = false;
        private Size minSize = new Size(619, 100);
        private Size minSizeTopPanel = new Size(619, 25);

        public event EventHandler BtnSendClick;
        public event EventHandler BtnMacroSettingsClick;
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
       // public event KeyPressEventArgs TbKeyPress;

        public MacroPannel()
        {
            InitializeComponent();
        }

        public override Size MinimumSize
        {
            get { return base.MinimumSize; }
            set { base.MinimumSize = minSize; }
        }

        public bool ShouldSerializeMaximumSize()
        {
            return false;
        }

        private void ResetMaximumSize()
        {
            base.MaximumSize = minSize;
        }

        public bool VisibleMacroButtons
        {
            get { return VisibleBotomPanel; }

            set
            {
                VisibleBotomPanel = value;
                if (VisibleBotomPanel == true)
                {
                    mainLayoutPanel.RowStyles[1].SizeType = SizeType.Absolute;
                    mainLayoutPanel.RowStyles[1].Height = 0F;
                    pnl_Botom.Size = new Size(619, 0);
                    base.MinimumSize = new Size(619, 25);
                    base.Size = new Size(619, 25);

                }
                else
                {
                    mainLayoutPanel.RowStyles[1].SizeType = SizeType.Absolute;
                    mainLayoutPanel.RowStyles[1].Height = 75F;
                    pnl_Botom.Size = new Size(619, 75);
                    base.MinimumSize = new Size(619, 100);
                    base.Size = new Size(619, 100);

                }

            }
        }

        public string BtnM1Text
        {
            get => btn_m1.Text;
            set => btn_m1.Text = value;
        }

        public string BtnM2Text
        {
            get => btn_m2.Text;
            set => btn_m2.Text = value;
        }
        public string BtnM3Text
        {
            get => btn_m3.Text;
            set => btn_m3.Text = value;
        }

        public string BtnM4Text
        {
            get => btn_m4.Text;
            set => btn_m4.Text = value;
        }

        public string BtnM5Text
        {
            get => btn_m5.Text;
            set => btn_m5.Text = value;
        }

        public string BtnM6Text
        {
            get => btn_m6.Text;
            set => btn_m6.Text = value;
        }

        public string BtnM7Text
        {
            get => btn_m7.Text;
            set => btn_m7.Text = value;
        }

        public string BtnM8Text
        {
            get => btn_m8.Text;
            set => btn_m8.Text = value;
        }

        public string BtnM9Text
        {
            get => btn_m9.Text;
            set => btn_m9.Text = value;
        }

        public string BtnM10Text
        {
            get => btn_m10.Text;
            set => btn_m10.Text = value;
        }

        public string BtnM11Text
        {
            get => btn_m11.Text;
            set => btn_m11.Text = value;
        }

        public string BtnM12Text
        {
            get => btn_m12.Text;
            set => btn_m12.Text = value;
        }

        public string BtnM13Text
        {
            get => btn_m13.Text;
            set => btn_m13.Text = value;
        }

        public string BtnM14Text
        {
            get => btn_m14.Text;
            set => btn_m14.Text = value;
        }

        public string BtnM15Text
        {
            get => btn_m15.Text;
            set => btn_m15.Text = value;
        }

        public string BtnM16Text
        {
            get => btn_m16.Text;
            set => btn_m16.Text = value;
        }

        public string BtnM17Text
        {
            get => btn_m17.Text;
            set => btn_m17.Text = value;
        }

        public string BtnM18Text
        {
            get => btn_m18.Text;
            set => btn_m18.Text = value;
        }

        public string BtnM19Text
        {
            get => btn_m19.Text;
            set => btn_m19.Text = value;
        }

        public string BtnM20Text
        {
            get => btn_m20.Text;
            set => btn_m20.Text = value;
        }


        protected void btn_Send_Click(object sender, EventArgs e) => this.BtnSendClick?.Invoke(this, e);


        private void btn_MacroSettings_Click(object sender, EventArgs e) => this.BtnMacroSettingsClick?.Invoke(this, e);


        private void btn_m1_Click(object sender, EventArgs e) => this.BtnM1Click?.Invoke(this, e);


        private void btn_m2_Click(object sender, EventArgs e) => this.BtnM2Click?.Invoke(this, e);


        private void btn_m3_Click(object sender, EventArgs e) => this.BtnM3Click?.Invoke(this, e);


        private void btn_m4_Click(object sender, EventArgs e) => this.BtnM4Click?.Invoke(this, e);


        private void btn_m5_Click(object sender, EventArgs e) => this.BtnM5Click?.Invoke(this, e);


        private void btn_m6_Click(object sender, EventArgs e) => this.BtnM6Click?.Invoke(this, e);


        private void btn_m7_Click(object sender, EventArgs e) => this.BtnM7Click?.Invoke(this, e);


        private void btn_m8_Click(object sender, EventArgs e) => this.BtnM8Click?.Invoke(this, e);


        private void btn_m9_Click(object sender, EventArgs e) => this.BtnM9Click?.Invoke(this, e);


        private void btn_m10_Click(object sender, EventArgs e) => this.BtnM10Click?.Invoke(this, e);


        private void btn_m11_Click(object sender, EventArgs e) => this.BtnM11Click?.Invoke(this, e);


        private void btn_m12_Click(object sender, EventArgs e) => this.BtnM12Click?.Invoke(this, e);


        private void btn_m13_Click(object sender, EventArgs e) => this.BtnM13Click?.Invoke(this, e);


        private void btn_m14_Click(object sender, EventArgs e) => this.BtnM14Click?.Invoke(this, e);


        private void btn_m15_Click(object sender, EventArgs e) => this.BtnM15Click?.Invoke(this, e);


        private void btn_m16_Click(object sender, EventArgs e) => this.BtnM16Click?.Invoke(this, e);


        private void btn_m17_Click(object sender, EventArgs e) => this.BtnM17Click?.Invoke(this, e);


        private void btn_m18_Click(object sender, EventArgs e) => this.BtnM18Click?.Invoke(this, e);


        private void btn_m19_Click(object sender, EventArgs e) => this.BtnM19Click?.Invoke(this, e);


        private void btn_m20_Click(object sender, EventArgs e) => this.BtnM20Click?.Invoke(this, e);

       // private void tb_Tx_KeyPress(object sender, KeyPressEventArgs e) => this.TbKeyPress?.Invoke(this, e);

       
    }
}
