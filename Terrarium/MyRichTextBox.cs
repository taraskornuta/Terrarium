using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Terrarium
{
    
    public class MyRichTextBox : RichTextBox
    {
        private bool autoscroll = false;
        private ContextMenuStrip cm = new ContextMenuStrip();
        private ToolStripMenuItem ts_Copy = new ToolStripMenuItem();
        private ToolStripMenuItem ts_Font = new ToolStripMenuItem();
        private ToolStripMenuItem ts_FontColor = new ToolStripMenuItem();

        public MyRichTextBox()
        {
            ts_Copy.Name = "Copy";
            ts_Copy.Text = "Copy";
            cm.Items.Add(ts_Copy);

            ts_FontColor.Name = "Font Color";
            ts_FontColor.Text = "Font Color";
            cm.Items.Add(ts_FontColor);

            ts_Font.Name = "Font Property";
            ts_Font.Text = "Font Property";
            cm.Items.Add(ts_Font);           

            cm.ItemClicked += new ToolStripItemClickedEventHandler(ContextMenuStrip_ItemClicked);


        }


        [Category("Appearance")]
        public bool Autoscroll
        {
            get
            {
                return autoscroll;
            }
            set
            {
                autoscroll = value;
                Invalidate();
            }
        }

        public void AppendTxt(string text)
        {
            AppendText(text);
            if (autoscroll == true) ScrollToCaret(); 
        }

        public void AppendHex(string hex)
        {
            byte[] data = Encoding.Default.GetBytes(hex);
            string hexString = BitConverter.ToString(data);
            hexString = hexString.Replace("-"," ");
            AppendText(hexString+" ");
            if (autoscroll == true) ScrollToCaret();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {               
                cm.Show(this, new Point(e.X, e.Y));
                
            }
        }

        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Text)
            {
                case "Copy":
                    cm.Hide();
                    if (this.SelectedText != "") //null check
                    {
                        Clipboard.SetText(this.SelectedText);
                    }                    
                    break;

                case "Font Property":
                    cm.Hide();
                    FontDialog fd = new FontDialog();
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        this.Font = fd.Font;
                    }
                    break;

                case "Font Color":
                    cm.Hide();
                    ColorDialog cd = new ColorDialog();
                    if (cd.ShowDialog() == DialogResult.OK)
                    {
                        this.ForeColor = cd.Color;
                    }
                    break;

                default:
                    break;
            }           
        }
    }
}

