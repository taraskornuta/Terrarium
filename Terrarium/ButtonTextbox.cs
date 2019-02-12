using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textboxInsideButton
{
    public partial class ButtonTextbox : UserControl
    {
        private TextBox tb = new TextBox();


        public ButtonTextbox()
        {
            InitializeComponent();
        }


        protected void OpenTextBox()
        {           
            tb.BorderStyle = BorderStyle.None;
            tb.BackColor = Color.FromArgb(185, 185, 185);
            tb.ForeColor = Color.WhiteSmoke;
            tb.Size = new Size(btn.Size.Width - 7, tb.Size.Height);
            tb.Location = new Point((int)btn.Location.X + 3, (int)btn.Location.Y + 4);
            tb.Font = new Font(Font.Name, 10);
            tb.Dock = DockStyle.None;
            btn.Controls.Add(tb);
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        protected void CloseTextBox()
        {
            btn.Controls.Remove(tb);
        }

        protected int btnClickCounter = 0;
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                btnClickCounter++;
                if (btnClickCounter == 2)
                {
                    btnClickCounter = 0;
                    OpenTextBox();
                }
            } 
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn.Text = tb.Text;
                CloseTextBox();
            }
        }
    }
}
