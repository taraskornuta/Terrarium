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
    public partial class FindForm : Form
    {
        public event EventHandler BtnFindEventHandler;

        public FindForm()
        {
            InitializeComponent();          
        }      

        #region Private Methods
        private void FindForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1D;
        }

        private void FindForm_Deactivate(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = .4D;
            }
            catch (Exception) { }    // exit with exception        
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btn_Delete_Click(object sender, EventArgs e) =>  txb_Find.Clear();
 

        private void btn_GetFromClipbrd_Click(object sender, EventArgs e)
        {
            txb_Find.Text = Clipboard.GetText();
        }

        private void btn_Find_Click(object sender, EventArgs e) => this.BtnFindEventHandler?.Invoke(this, e);


        #endregion

        #region Public Methods

        public double FormOpacity
        {          
            get => this.Opacity;
            set => this.Opacity = value;
        }

        public string SearchData
        {
            get => this.txb_Find.Text;
            set => this.txb_Find.Text = value;
        }

        public eDataFormat DataFormat
        {
            get => this.dataFormatSwitch.DataFormat;
            set
            {
                if (value <= eDataFormat.HEX)
                {
                    this.dataFormatSwitch.DataFormat = value;
                }
                else
                {
                    this.dataFormatSwitch.DataFormat = value - 3;
                }
            }               
        }
        #endregion


    }
}
