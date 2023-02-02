using System.ComponentModel.Design;
using System.Text;

namespace HexConvert
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Help.Display();
                Environment.Exit(1);
            }

            string stringToConvert = args[0];
            Console.WriteLine(EncodeDecode.HexEncode(stringToConvert));
            Console.WriteLine(EncodeDecode.HexDecode(EncodeDecode.HexEncode(stringToConvert)));
        }
    }
}