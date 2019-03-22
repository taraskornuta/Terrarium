using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terrarium
{
    public static class TextHelper
    {
        public static byte[] StringToHex(string hex)
        {
            hex = hex.Replace(" ", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        public static string HexToString(byte[] data)
        {
            string hexString = BitConverter.ToString(data);
            hexString = hexString.Replace("-", " ");
            return hexString;
        }

        public static bool IsNumberEntered(string text)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(text, "[^0-9]");
        }

        public static bool IsHexEntered(string text)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(text, "[^0-9a-fA-F ]");
        }

        public static string[] StringSplit(this string value, int chunkSize)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("The string cannot be null.");
            if (chunkSize < 1) throw new ArgumentException("The chunk size should be equal or greater than one.");

            int remainder;
            int divResult = Math.DivRem(value.Length, chunkSize, out remainder);

            int numberOfChunks = remainder > 0 ? divResult + 1 : divResult;
            var result = new string[numberOfChunks];

            int i = 0;
            while (i < numberOfChunks - 1)
            {
                result[i] = value.Substring(i * chunkSize, chunkSize);
                i++;
            }

            int lastChunkSize = remainder > 0 ? remainder : chunkSize;
            result[i] = value.Substring(i * chunkSize, lastChunkSize);

            return result;
        }


        public static byte[] ByteSplit(byte[] value, int chunkSize)
        {
            int remainder;
            int divResult = Math.DivRem(value.Length, chunkSize, out remainder);

            int numberOfChunks = remainder > 0 ? divResult + 1 : divResult;
            var result = new byte[numberOfChunks];

            int i = 0;
            while (i < numberOfChunks - 1)
            {
                result[i] = value[i * chunkSize];
                i++;
            }

            int lastChunkSize = remainder > 0 ? remainder : chunkSize;
            result[i] = value[lastChunkSize];

            return result;
        }


       

        //Contains the substition strings for the characters. A char --> string mapping.
        private static Dictionary<byte, string> lSpecialDict = new Dictionary<byte, string>() 
        {
            {0x00, "NUL" }, {0x01, "SOH" }, {0x02, "STX" },
            {0x03, "ETX" }, {0x04, "EOT" }, {0x05, "ENQ" },
            {0x06, "ACK" }, {0x07, "BEL" }, {0x08, "BS"  },
            {0x09, "HT"  }, {0x0A, "LF"  }, {0x0B, "VT"  },
            {0x0C, "FF"  }, {0x0D, "CR"  }, {0x0E, "SO"  },
            {0x0F, "SI"  }, {0x10, "DLE" }, {0x11, "DC1" },
            {0x12, "DC2" }, {0x13, "DC3" }, {0x14, "DC4" },
            {0x15, "NAK" }, {0x16, "SYN" }, {0x17, "ETB" },
            {0x18, "CAN" }, {0x19, "EM"  }, {0x1A, "SUB" },
            {0x1B, "ESC" }, {0x1C, "FS"  }, {0x1D, "GS"  },
            {0x1E, "RS"  }, {0x1F, "US"  }, {0x7F, "DEL" },
        };


        public static void ByteToAscii(this RichTextBox box, byte[] data)
        {
            byte[] arr = new byte[1];
            for (int i = 0; i < data.Length; i++)
            {
                if (lSpecialDict.ContainsKey(data[i]))
                {
                    string replacement;
                    lSpecialDict.TryGetValue(data[i], out replacement);
                    box.AppendText("[" + replacement + "]", Color.LightGray, Color.Firebrick);     
                }
                else
                {                   
                    arr[0] = data[i];

                    if (data[i] > 127)
                    {
                        box.AppendText("[" + HexToString(arr) + "]", Color.LightGray, Color.Firebrick);
                    }
                    else
                    {
                        box.AppendText(Encoding.ASCII.GetString(arr) + "");
                    }

                }
            }
        }


        public static void AppendText(this RichTextBox box, string text, Color bgcolor, Color fontcolor)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            var saved = box.SelectionBackColor;
            var saved2 = box.SelectionColor;
            //box.SelectionBackColor = bgcolor;
            box.SelectionColor = fontcolor;
            box.AppendText(text);
            box.SelectionBackColor = saved;
            box.SelectionColor = saved2;
        }

    }

    public static class ByteHelper
    {
        private static int dataLength = 0;
        private static int counter = 0;

        // should be called when screen is cleared
        public static void ResetChunkCounter()
        {
            counter = 0;
        }


        public static void DivideByChunk(this RichTextBox box, byte[] data, int chunkSize)
        {
            byte[] arr = new byte[1];
            while (dataLength < data.Length)
            {
                if (counter == chunkSize)
                {
                    counter = 0;
                    box.AppendText("\n");                       // print \n to move to next line
                }
                
                arr[0] = data[dataLength];
                box.AppendText(Encoding.ASCII.GetString(arr));  // @TODO should print ASCII, HEX, DEC, BIN or both

                dataLength++;
                counter++;
            }
        }

    }

}
