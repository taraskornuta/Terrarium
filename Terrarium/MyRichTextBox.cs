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

    }
}

