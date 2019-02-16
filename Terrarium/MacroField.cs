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
    public partial class MacroField : UserControl
    {
        public event EventHandler btnTextChangeEvent;
        public event EventHandler btnClickEvent;

        public MacroField()
        {
            InitializeComponent();

            btntb_Send.ButtonTextChangeEvent += new EventHandler(btn_TextChanged);
            btntb_Send.BtnClickEvent += new EventHandler(btn_Click);
        }

        public string TextBoxText
        {
            get => tb_MacroData.Text;
            set => tb_MacroData.Text = value;
        }

        public decimal RepeatTimeValue
        {
            get => numBox.Value;
            set => numBox.Value = value;

        }

        public bool HexMode
        {
            get => cb_HEX.Checked;
            set => cb_HEX.Checked = value;
        }

        public bool RepeatActive
        {
            get => cb_Repeat.Checked;
            set => cb_Repeat.Checked = value;
        }

        public string ButtonText
        {
            get => btntb_Send.btn.Text;
            set => btntb_Send.btn.Text = value;
        }
 
        private void btn_TextChanged(object sender, EventArgs e) => btnTextChangeEvent?.Invoke(this, e);
        private void btn_Click(object sender, EventArgs e) => btnClickEvent?.Invoke(this, e);

    }
}
