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
        private static int counter = 0;

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

        public static string ByteToHexString(byte data)
        {
            byte[] array = new byte[1];
            array[0] = data;
            string hexString = BitConverter.ToString(array);
            hexString = hexString.Replace("-", " ");
            return hexString;
        }

        public static string ByteToBinaryString(byte data)
        {
            byte[] array = new byte[8];
            string result = "";
            for (byte i = 0; i < array.Length; i++)
            {
                array[7 - i] = (byte)(data % 2);
                data /= 2;
            }

            for (byte i = 0; i < array.Length; i++)
            {
                result += array[i].ToString();
            }
            return result;
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
        private static Dictionary<byte, string> AsciiCtrlCharDict = new Dictionary<byte, string>() 
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

        // should be called when screen is cleared
        public static void ResetChunkCounter()
        {
            counter = 0;
        }

        public static void ByteFormatPrint(this NumberedRTB box, byte[] data, eDataFormat dataFormat, bool isDividedByChunk, int chunkSize, bool caretScroll)
        {
            int dataLength = 0;
            byte[] chunkBuff = new byte[1];
            string strBuild = "";

            switch (dataFormat)
            {
                case eDataFormat.NONE:
                {
                    while (dataLength < data.Length)
                    {
                        if (isDividedByChunk == true)
                        {
                            if (counter == chunkSize)
                            {
                                counter = 0;
                                strBuild += "\n";
                            }
                            counter++;
                        }
                        chunkBuff[0] = data[dataLength];
                        strBuild += Encoding.ASCII.GetString(chunkBuff);
                        dataLength++;
                    }

                    box.AppendText(strBuild);
                    if ((isDividedByChunk == false) || (caretScroll == true)) box.RichTextBox.ScrollToCaret();
                    break;
                }

                case eDataFormat.ASCII:
                {
                     while (dataLength < data.Length)
                     {
                         if (isDividedByChunk == true)
                         {
                             if (counter == chunkSize)
                             {
                                 counter = 0;
                                 box.AppendText("\n");                       // print \n to move to next line
                                 if (caretScroll == true) box.RichTextBox.ScrollToCaret();
                             }
                            counter++;
                         }

                         if (AsciiCtrlCharDict.ContainsKey(data[dataLength]))
                         {
                             string replacement;
                             AsciiCtrlCharDict.TryGetValue(data[dataLength], out replacement);
                             box.AppendText("[" + replacement + "] ", Color.LightGray, Color.Green);
                         }
                         else
                         {
                             chunkBuff[0] = data[dataLength];
                             box.AppendText(Encoding.ASCII.GetString(chunkBuff));
                         }
                         
                         dataLength++;                       
                     }
                     if ((isDividedByChunk == false) && (caretScroll == true)) box.RichTextBox.ScrollToCaret();
                     break;
                }   
                
                    
                case eDataFormat.BIN:
                {
                    while (dataLength < data.Length)
                    {
                        if (isDividedByChunk == true)
                        {
                            if (counter == chunkSize)
                            {
                                counter = 0;
                                strBuild += "\n";                       // print \n to move to next line
                            }
                            counter++;
                        }

                        strBuild += "[" + ByteToBinaryString(data[dataLength]) + "] ";
                        dataLength++;
                    }
                    box.AppendText(strBuild);
                    if ((isDividedByChunk == false) || (caretScroll == true)) box.RichTextBox.ScrollToCaret();
                    break;
                }
                

                case eDataFormat.DEC:
                {
                    while (dataLength < data.Length)
                    {
                        if (isDividedByChunk == true)
                        {
                            if (counter == chunkSize)
                            {
                                counter = 0;
                                strBuild += "\n";                       // print \n to move to next line
                            }
                            counter++;
                        }
                        strBuild += "[" + data[dataLength].ToString() + "] ";
                        dataLength++;
                    }
                    box.AppendText(strBuild);
                    if ((isDividedByChunk == false) || (caretScroll == true)) box.RichTextBox.ScrollToCaret();
                    break;
                }
                

                case eDataFormat.HEX:
                {
                    while (dataLength < data.Length)
                    {
                        if (isDividedByChunk == true)
                        {
                            if (counter == chunkSize)
                            {
                                counter = 0;
                                strBuild += "\n";                       // print \n to move to next line
                            }
                            counter++;
                        }
                        strBuild += "[" + ByteToHexString(data[dataLength]) + "] ";
                        dataLength++;
                    }
                    box.AppendText(strBuild);
                    if ((isDividedByChunk == false) || (caretScroll == true)) box.RichTextBox.ScrollToCaret();
                    break;
                }
                    
                case eDataFormat.ASCIIBIN:
                {
                    while (dataLength < data.Length)
                    {
                        if (isDividedByChunk == true)
                        {
                            if (counter == chunkSize)
                            {
                                counter = 0;
                                box.AppendText("\n");                       // print \n to move to next line
                                if (caretScroll == true) box.RichTextBox.ScrollToCaret();
                            }
                            counter++;
                        }

                        if (AsciiCtrlCharDict.ContainsKey(data[dataLength]))
                        {
                            string replacement;
                            AsciiCtrlCharDict.TryGetValue(data[dataLength], out replacement);
                            box.AppendText("'" + replacement + "'", Color.LightGray, Color.Green);
                            box.AppendText("[" + ByteToBinaryString(data[dataLength]) + "] ", Color.LightGray, Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190))))));
                        }
                        else
                        {
                            chunkBuff[0] = data[dataLength];
                            box.AppendText("'" + Encoding.ASCII.GetString(chunkBuff) + "'");
                            box.AppendText("[" + ByteToBinaryString(data[dataLength]) + "] ", Color.LightGray, Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190))))));
                        }
                        dataLength++;
                    }
                        if ((isDividedByChunk == false) && (caretScroll == true)) box.RichTextBox.ScrollToCaret();
                        break;
                }

                case eDataFormat.ASCIIDEC:
                {
                    while (dataLength < data.Length)
                    {
                        if (isDividedByChunk == true)
                        {
                            if (counter == chunkSize)
                            {
                                counter = 0;
                                box.AppendText("\n");                       // print \n to move to next line
                                if (caretScroll == true) box.RichTextBox.ScrollToCaret();
                            }
                            counter++;
                        }

                        if (AsciiCtrlCharDict.ContainsKey(data[dataLength]))
                        {
                            string replacement;
                            AsciiCtrlCharDict.TryGetValue(data[dataLength], out replacement);
                            box.AppendText("'" + replacement + "'", Color.LightGray, Color.Green);
                            box.AppendText("[" + data[dataLength].ToString() + "] ", Color.LightGray, Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190))))));
                        }
                        else
                        {
                            chunkBuff[0] = data[dataLength];
                            box.AppendText("'" + Encoding.ASCII.GetString(chunkBuff) + "'");
                            box.AppendText("[" + data[dataLength].ToString() + "] ", Color.LightGray, Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190))))));
                        }
                        dataLength++;
                    }
                        if ((isDividedByChunk == false) && (caretScroll == true)) box.RichTextBox.ScrollToCaret();
                        break;
                }

                    
                case eDataFormat.ASCIIHEX:
                {
                    while (dataLength < data.Length)
                    {
                        if (isDividedByChunk == true)
                        {
                            if (counter == chunkSize)
                            {
                                counter = 0;
                                box.AppendText("\n");                       // print \n to move to next line
                                if (caretScroll == true) box.RichTextBox.ScrollToCaret();
                            }
                            counter++;
                        }

                        if (AsciiCtrlCharDict.ContainsKey(data[dataLength]))
                        {
                            string replacement;
                            AsciiCtrlCharDict.TryGetValue(data[dataLength], out replacement);
                            box.AppendText("'" + replacement + "'", Color.LightGray, Color.Green);
                            box.AppendText("[" + ByteToHexString(data[dataLength]) + "] ", Color.LightGray, Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190))))));
                        }
                        else
                        {
                            chunkBuff[0] = data[dataLength];
                            box.AppendText("'" + Encoding.ASCII.GetString(chunkBuff) + "'");
                            box.AppendText("[" + ByteToHexString(data[dataLength]) + "] ", Color.LightGray, Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(190))))));
                        }
                        dataLength++;
                    }
                        if ((isDividedByChunk == false) && (caretScroll == true)) box.RichTextBox.ScrollToCaret();
                        break;
                }               
            }
        }



        public static void AppendText(this NumberedRTB box, string text, Color bgcolor, Color fontcolor)
        {
            box.RichTextBox.SelectionStart = box.RichTextBox.TextLength;
            box.RichTextBox.SelectionLength = 0;

            var saved = box.RichTextBox.SelectionBackColor;
            var saved2 = box.RichTextBox.SelectionColor;
            //box.SelectionBackColor = bgcolor;
            box.RichTextBox.SelectionColor = fontcolor;
            box.RichTextBox.AppendText(text);
            box.RichTextBox.SelectionBackColor = saved;
            box.RichTextBox.SelectionColor = saved2;
        }
    } 
}
