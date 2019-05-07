using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Terrarium
{
    public class FlattenCombo : ComboBox
    {
        private Brush BorderBrush = new SolidBrush(SystemColors.WindowFrame);
        private Brush ArrowBrush = new SolidBrush(SystemColors.ControlText);
        private Brush DropButtonBrush = new SolidBrush(SystemColors.Control);

        private Color _borderColor = Color.Black;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;

        private Color _ButtonColor = SystemColors.Control;

        public Color ButtonColor
        {
            get { return _ButtonColor; }
            set
            {
                _ButtonColor = value;
                DropButtonBrush = new SolidBrush(this.ButtonColor);
                this.Invalidate();
            }
        }


        private int yPos = 0;
        private int xPos = 0;
        private int scrollPos = 0;
        private int xFactor = -1;
        private int simpleOffset = 0;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetScrollInfo(IntPtr hWnd, int n, ref ScrollInfoStruct lpScrollInfo);

        // Win32 constants
        private const int SB_VERT = 1;
        private const int SIF_TRACKPOS = 0x10;
        private const int SIF_RANGE = 0x1;
        private const int SIF_POS = 0x4;
        private const int SIF_PAGE = 0x2;
        private const int SIF_ALL = SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS;

        private const int SCROLLBAR_WIDTH = 17;
        private const int LISTBOX_YOFFSET = 21;

        // Return structure for the GetScrollInfo method
        [StructLayout(LayoutKind.Sequential)]
        private struct ScrollInfoStruct
        {
            public int cbSize;
            public int fMask;
            public int nMin;
            public int nMax;
            public int nPage;
            public int nPos;
            public int nTrackPos;
        }

        public event HoverEventHandler Hover;

        protected virtual void OnHover(HoverEventArgs e)
        {
            HoverEventHandler handler = Hover;
            if (handler != null)
            {
                // Invokes the delegates. 
                handler(this, e);
            }
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if ((m.Msg == 308) || (m.Msg == 32))
            {
                int onScreenIndex = 0;

                // Get the mouse position relative to this control
                Point LocalMousePosition = this.PointToClient(Cursor.Position);
                xPos = LocalMousePosition.X;

                yPos = LocalMousePosition.Y - this.Size.Height - 1;
                int oldYPos = yPos;

                while (yPos >= this.ItemHeight)
                {
                    yPos -= this.ItemHeight;
                    onScreenIndex++;
                }

                ScrollInfoStruct si = new ScrollInfoStruct();
                si.fMask = SIF_ALL;
                si.cbSize = Marshal.SizeOf(si);

                int getScrollInfoResult = 0;
                getScrollInfoResult = GetScrollInfo(m.LParam, SB_VERT, ref si);

                if (getScrollInfoResult > 0)
                {
                    onScreenIndex += si.nTrackPos;

                    if (this.DropDownStyle == ComboBoxStyle.Simple)
                    {
                        simpleOffset = si.nTrackPos;
                    }
                }

                if (!(xPos > this.Width - SCROLLBAR_WIDTH || xPos < 1 || oldYPos < 0 || ((oldYPos > this.ItemHeight * this.MaxDropDownItems) && this.DropDownStyle != ComboBoxStyle.Simple)))
                {
                    HoverEventArgs e = new HoverEventArgs();
                    e.itemIndex = (onScreenIndex > this.Items.Count - 1) ? this.Items.Count - 1 : onScreenIndex;
                    OnHover(e);

                    if (scrollPos != si.nPos)
                    {
                        Cursor.Position = new Point(Cursor.Position.X + xFactor, Cursor.Position.Y);
                        xFactor = -xFactor;
                    }
                }
                scrollPos = si.nPos;

            }

            if (m.Msg == WM_PAINT)
            {
            
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(Color.Black);
                //g.FillRectangle(BorderBrush, this.ClientRectangle);

                //Draw the background of the dropdown button
                Rectangle rect = new Rectangle(this.Width - 17, 0, 17, this.Height);
                g.FillRectangle(DropButtonBrush, rect);

                //Create the path for the arrow
                System.Drawing.Drawing2D.GraphicsPath pth = new System.Drawing.Drawing2D.GraphicsPath();
                PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
                PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);
                PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
                pth.AddLine(TopLeft, TopRight);
                pth.AddLine(TopRight, Bottom);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                //Determine the arrow's color.
                if (this.DroppedDown)
                {
                    ArrowBrush = new SolidBrush(SystemColors.HighlightText);
                }
                else
                {
                    ArrowBrush = new SolidBrush(SystemColors.ControlText);
                }

                //Draw the arrow
                g.FillPath(ArrowBrush, pth);

           
            }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); // causes control to be redrawn
            }
        }

        [Category("Appearance")]
        public ButtonBorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }

        protected override void OnLostFocus(System.EventArgs e)
        {
            base.OnLostFocus(e);
            this.Invalidate();
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            this.Invalidate();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
    }


    /// <summary>
    /// Class that contains data for the hover event 
    /// </summary>
    public class HoverEventArgs : EventArgs
    {
        private int _itemIndex = 0;
        public int itemIndex
        {
            get
            {
                return _itemIndex;
            }
            set
            {
                _itemIndex = value;
            }
        }
    }

    /// <summary>
    /// Delegate declaration 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void HoverEventHandler(object sender, HoverEventArgs e);
}
