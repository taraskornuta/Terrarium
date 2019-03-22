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
    public enum eButtonState
    {
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
        private int milliseconds = 0;
        private int doubleClickInterval = 1;
        private eButtonState btnState;

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

        public eButtonState BtnState
        {
            get => btnState;
            set
            {
                btnState = value;
                applyState(btnState);
            }
        }

        public DataFormaterSwitch()
        {
            InitializeComponent();            
            doubleClickTimer.Tick += new EventHandler(doubleClickTimer_Tick);
            applyState(btnState);
        }
        
        void doubleClickTimer_Tick(object sender, EventArgs e)
        {
            milliseconds += 100;
            // The timer has reached the double click time limit.
            if (milliseconds >= SystemInformation.DoubleClickTime)
            {
                doubleClickTimer.Stop();

                if (isDoubleClick)
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

        private void applyState(eButtonState buttonState)
        {
            allBtnsResetBackColor();
            switch (buttonState)
            {
                case eButtonState.ASCII:
                    btn_ascii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
                    break;
                case eButtonState.BIN:
                    btn_bin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
                    break;
                case eButtonState.DEC:
                    btn_dec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
                    break;
                case eButtonState.HEX:
                    btn_hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
                    break;
                case eButtonState.ASCIIBIN:
                    btn_ascii.BackColor = Color.Red;
                    btn_bin.BackColor = Color.Yellow;
                    break;
                case eButtonState.ASCIIDEC:
                    btn_ascii.BackColor = Color.Red;
                    btn_dec.BackColor = Color.Yellow;
                    break;
                case eButtonState.ASCIIHEX:
                    btn_ascii.BackColor = Color.Red;
                    btn_hex.BackColor = Color.Yellow;
                    break;
            }
        }
       

        private void btn_ascii_DoubleClick()
        {
            combyneKeys = true;
            btnState = eButtonState.ASCIIBIN;
            applyState(btnState);
        }

        private void btn_ascii_Click()
        {
            combyneKeys = false;
            btnState = eButtonState.ASCII;
            applyState(btnState);
        }

        private void btn_bin_Click(object sender, EventArgs e)
        {
            if (combyneKeys == false)
            {
                btnState = eButtonState.BIN;
            }
            else
            {
                btnState = eButtonState.ASCIIBIN;
            }           
            applyState(btnState);
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            if (combyneKeys == false)
            {
                btnState = eButtonState.DEC;
            }
            else
            {
                btnState = eButtonState.ASCIIDEC;
            }
            applyState(btnState);
        }

        private void btn_hex_Click(object sender, EventArgs e)
        {
            if (combyneKeys == false)
            {
                btnState = eButtonState.HEX;
            }
            else
            {
                btnState = eButtonState.ASCIIHEX;
            }
            applyState(btnState);
        }
    }
}
