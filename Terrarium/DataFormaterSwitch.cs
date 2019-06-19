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
    public enum eDataFormat
    {
        NONE,     
        ASCII,
        BIN,
        DEC,
        HEX,
        ASCIIBIN,
        ASCIIDEC,
        ASCIIHEX 
    }

    public partial class DataFormaterSwitch : UserControl
    {
        private Timer doubleClickTimer = new Timer();
        private bool isFirstClick = true;
        private bool isDoubleClick = false;
        private bool combyneKeys = false;
        private bool isCombyneKeysAllow = false;
        private int milliseconds = 0;
        private int doubleClickInterval = 1;
        private eDataFormat Format;

        public bool AllowCombyneKeys
        {
            get => isCombyneKeysAllow;
            set => isCombyneKeysAllow = value;
        }

        public int DoubleClickInterval
        {
            get => doubleClickInterval;
            set
            {
                if (value == 0) doubleClickInterval = 1;
                else doubleClickInterval = value;
                doubleClickTimer.Interval = doubleClickInterval;
            }
        }

        public eDataFormat DataFormat
        {
            get => Format;
            set
            {
                Format = value;
                applyState(Format);
            }
        }

        public DataFormaterSwitch()
        {
            InitializeComponent();
            doubleClickTimer.Tick += new EventHandler(doubleClickTimer_Tick);

            if (DataFormat <= eDataFormat.HEX || DataFormat == eDataFormat.NONE)
            {
                combyneKeys = false;
            }
            else
            {
                combyneKeys = true;
            }
            applyState(Format);
        }
        
        void doubleClickTimer_Tick(object sender, EventArgs e)
        {
            milliseconds += 100;
            // The timer has reached the double click time limit.
            if (milliseconds >= SystemInformation.DoubleClickTime)
            {
                doubleClickTimer.Stop();

                if (isDoubleClick && isCombyneKeysAllow)
                {
                    btn_ascii_DoubleClick();
                }
                else
                {
                    btn_ascii_Click();
                }
                // Allow the MouseDown event handler to process clicks again.
                isFirstClick = true;
                isDoubleClick = false;
                milliseconds = 0;
            }
        }

        private void btn_ascii_MouseDown(object sender, MouseEventArgs e)
        {           
            if (isFirstClick)              // This is the first mouse click.
            {
                isFirstClick = false;              
                doubleClickTimer.Start();  // Start the double click timer.
            }                                        
            else                           // This is the second mouse click.
            {
                // Verify that the mouse click is within the double click
                // click period.
                if (milliseconds < SystemInformation.DoubleClickTime)
                {
                    isDoubleClick = true;
                }
            }
        }

        private void allBtnsResetBackColor()
        {
            btn_ascii.BackColor = btn_bin.BackColor = btn_dec.BackColor = btn_hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
        }


        const byte btnEnabledColor = 100;
        private void applyState(eDataFormat buttonState)
        {
            allBtnsResetBackColor();
            switch (buttonState)
            {
                case eDataFormat.NONE:
                    btnAsciiFlag = false;
                    btn_ascii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
                    break;
                case eDataFormat.ASCII:
                    btnAsciiFlag = true;
                    btn_ascii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(btnEnabledColor)))), ((int)(((byte)(btnEnabledColor)))), ((int)(((byte)(btnEnabledColor)))));
                    break;
                case eDataFormat.BIN:
                    btn_bin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(btnEnabledColor)))), ((int)(((byte)(btnEnabledColor)))), ((int)(((byte)(btnEnabledColor)))));
                    break;
                case eDataFormat.DEC:
                    btn_dec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(btnEnabledColor)))), ((int)(((byte)(btnEnabledColor)))), ((int)(((byte)(btnEnabledColor)))));
                    break;
                case eDataFormat.HEX:
                    btn_hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(btnEnabledColor)))), ((int)(((byte)(btnEnabledColor)))), ((int)(((byte)(btnEnabledColor)))));
                    break;
                case eDataFormat.ASCIIBIN:
                    btn_ascii.BackColor = Color.Red;
                    btn_bin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
                    break;
                case eDataFormat.ASCIIDEC:
                    btn_ascii.BackColor = Color.Red;
                    btn_dec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
                    break;
                case eDataFormat.ASCIIHEX:
                    btn_ascii.BackColor = Color.Red;
                    btn_hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
                    break;
            }
        }
       

        private void btn_ascii_DoubleClick()
        {
            combyneKeys = true;
            Format = eDataFormat.ASCIIBIN;
            applyState(Format);
        }

        private bool btnAsciiFlag;
        private void btn_ascii_Click()
        {
            if (btnAsciiFlag == true)
            {
                Format = eDataFormat.NONE;
            }
            else
            {
                combyneKeys = false;
                Format = eDataFormat.ASCII;
            }
            btnAsciiFlag ^= true;
            applyState(Format);
        }

        private void btn_bin_Click(object sender, EventArgs e)
        {
            btnAsciiFlag = false;
            if (combyneKeys == false)
            {
                Format = eDataFormat.BIN;
            }
            else
            {
                Format = eDataFormat.ASCIIBIN;
            }           
            applyState(Format);
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            btnAsciiFlag = false;
            if (combyneKeys == false)
            {
                Format = eDataFormat.DEC;
            }
            else
            {
                Format = eDataFormat.ASCIIDEC;
            }
            applyState(Format);
        }

        private void btn_hex_Click(object sender, EventArgs e)
        {
            btnAsciiFlag = false;
            if (combyneKeys == false)
            {
                Format = eDataFormat.HEX;
            }
            else
            {
                Format = eDataFormat.ASCIIHEX;
            }
            applyState(Format);
        }
    }
}
