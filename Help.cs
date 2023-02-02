using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace HexConvert
{
    internal static class Help
    {
        private const string Version = "0.01";

        private const string HelpSauce = $"Hex Converter, v{Version}\n" +
                                    "\n" +
                                    "Usage:\n" +
                                    "    HexConverter.exe \"<arg>\"" +
                                    "\n";
        public static void Display()
        {
            Console.WriteLine(HelpSauce);
        }

    }
}
