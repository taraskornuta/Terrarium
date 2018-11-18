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
    public partial class TextReceiver : UserControl
    {
        private bool lineNumber = false;
        private bool autoscroll = false;

        public TextReceiver()
        {
            InitializeComponent();
            numberLabel.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size + 1.019f);
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

        [Category("Appearance")]
        public bool LineNumber
        {
            get
            {
                return lineNumber;
            }
            set
            {
                lineNumber = value;
                if (lineNumber == true)
                {
                    panel1.Width = 40;
                }
                else
                {
                    panel1.Width = 0;
                }
                Invalidate();
            }
        }

        public void AppendText(string text)
        {
            richTextBox1.AppendText(text);
            if (autoscroll == true) richTextBox1.ScrollToCaret();
        }

        public void AppendHex(string hex)
        {
            byte[] data = Encoding.Default.GetBytes(hex);
            string hexString = BitConverter.ToString(data);
            hexString = hexString.Replace("-", " ");
            AppendText(hexString + " ");
            if (autoscroll == true) richTextBox1.ScrollToCaret();
        }

        public void Clear()
        {
            richTextBox1.Clear();
        }


        private void updateNumberLabel()
        {
            //we get index of first visible char and number of first visible line
            Point pos = new Point(0, 0);
            int firstIndex = richTextBox1.GetCharIndexFromPosition(pos);
            int firstLine = richTextBox1.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = richTextBox1.GetCharIndexFromPosition(pos);
            int lastLine = richTextBox1.GetLineFromCharIndex(lastIndex);

            //this is point position of last visible char, we'll use its Y value for calculating numberLabel size
            pos = richTextBox1.GetPositionFromCharIndex(lastIndex);

            //finally, renumber label
            numberLabel.Text = "";
            for (int i = firstLine; i <= lastLine + 1; i++)
            {
                numberLabel.Text += i + 1 + "\n";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            updateNumberLabel();

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            //move location of numberLabel for amount of pixels caused by scrollbar
            int d = richTextBox1.GetPositionFromCharIndex(0).Y % (richTextBox1.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            updateNumberLabel();
        }

        private void richTextBox1_Resize(object sender, EventArgs e)
        {
            richTextBox1_VScroll(null, null);
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            updateNumberLabel();
            richTextBox1_VScroll(null, null);
        }


    }
}
