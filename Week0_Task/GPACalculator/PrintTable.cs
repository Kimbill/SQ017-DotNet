using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPACalculator
{
    class PrintTable
    {
        private const int TableWidth = 100;
        public static void PrintLine()
        {
            Console.WriteLine(new String('-', TableWidth));
        }

        public static void PrintRow(params string[] col)
        {
            int Width = (TableWidth - col.Length) / col.Length;
            const string seed = "|";
            string row = col.Aggregate(seed, (seperator, colText) => seperator + GetCenterAllignedText(colText, Width) + seed);
            Console.WriteLine(row);
        }

        private static string GetCenterAllignedText(string colText, int width)
        {
            colText = colText.Length > width ? colText.Substring(0, width - 3) + "..." : colText;
            return string.IsNullOrEmpty(colText) ? new string(' ', width)
                : colText.PadRight(width - ((width - colText.Length) / 2)).PadLeft(width);
        }
    }
}
