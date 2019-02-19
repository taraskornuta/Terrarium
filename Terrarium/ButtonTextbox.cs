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
        protected int btnClickCounter = 0;
        public event EventHandler BtnClickEvent;
        public event EventHandler ButtonTextChangeEvent;

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
            tb.MouseDoubleClick += new MouseEventHandler(tb_MouseDoubleClick);
        }


        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                btnClickCounter++;
                if (btnClickCounter == 2)
                {
                    btnClickCounter = 0;
                    OpenTextBox();
                    tb.Select();
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                btnClickCounter = 0;
                btn.Controls.Remove(tb);
            }
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn.Text = tb.Text;
                btn.Controls.Remove(tb);
            }
        }

        private void tb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn.Text = tb.Text;
            btnClickCounter = 0;
            btn.Controls.Remove(tb);
        }

        private void btn_TextChanged(object sender, EventArgs e) => ButtonTextChangeEvent?.Invoke(this, e);
        private void btn_Click(object sender, EventArgs e) => BtnClickEvent?.Invoke(this, e);

    }
}
