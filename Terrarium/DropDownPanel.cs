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
    public partial class DropDownPanel : UserControl
    {
        private Image panelIcon;
        private string panelText;
        private bool panelOpened;
        private bool buttonEnabled;
        public event EventHandler ButtonEvent;

        public DropDownPanel()
        {
            InitializeComponent();
        }

        public Image PanelIcon { get => panelIcon; set =>  iconBox.Image = panelIcon = value; }
        public string PanelText { get => panelText; set => lbl_Text.Text = panelText = value; }
        public bool ButtonEnable { get => buttonEnabled; set => btn_Open.Visible = buttonEnabled = value; }
        public bool PanelOpened
        {
            get => panelOpened;
            set
            {
                panelOpened = value;
                if (panelOpened == false)
                {

                    btn_Open.Image = Properties.Resources.icons8_Sort_Left_16px;
                }
                else
                {
                    btn_Open.Image = Properties.Resources.icons8_Sort_Down_16px;
                }
            }
        }

        private void btn_Open_Click(object sender, EventArgs e) => this.ButtonEvent?.Invoke(this, e);


    }
}
