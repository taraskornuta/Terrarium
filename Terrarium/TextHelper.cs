using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
