using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Terrarium
{
    class MyRichTextBox : RichTextBox
    {
        private bool autoscroll = false;
        ContextMenuStrip cm = new ContextMenuStrip();
        ToolStripMenuItem ts_Copy = new ToolStripMenuItem();
        ToolStripMenuItem ts_Property = new ToolStripMenuItem();


        public MyRichTextBox()
        {
            ts_Copy.Name = "Copy";
            ts_Copy.Text = "Copy";
            cm.Items.Add(ts_Copy);

            ts_Property.Name = "Property";
            ts_Property.Text = "Property";
            cm.Items.Add(ts_Property);

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
                    MessageBox.Show(e.ClickedItem.Text);
                    break;
                case "Property":
                    MessageBox.Show(e.ClickedItem.Text);
                    break;
            }

            //MessageBox.Show(e.ClickedItem.Text);
        }


    }

}

