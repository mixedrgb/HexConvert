using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexConvert
{
    internal static class EncodeDecode
    {
        public static string HexDecode(string stringToDecode)
        {
            string[] splitValues = stringToDecode.Split(' ');
            string stringValue = "";

            foreach (string hex in splitValues)
            {
                int value = Convert.ToInt32(hex, 16);
                stringValue += Char.ConvertFromUtf32(value);
            }

            return stringValue;
        }

        public static string HexEncode(string stringToEncode)
        {
            byte[] ba = Encoding.Default.GetBytes(stringToEncode);
            var hexStr = BitConverter.ToString(ba);
            hexStr = hexStr.Replace("-", " ");

            return hexStr;
        }

    }
}
