using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrarium
{
    public class TextHelper
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
    }
}
