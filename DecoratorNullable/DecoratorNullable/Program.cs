using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorNullable
{
    class Program
    {
        static void PrintNumber(int? number)
        {
            //int printed_text1 = number != null ? number.Value : 0;

            int printed_text2 = number ?? throw new Exception(); // if not null return itself otherwise return 0

            Console.WriteLine(printed_text2);

            float? o = 1.3f;
            bool? b = true;

            int? x = null;
            int y = 0;

            //Console.WriteLine(number?? : "");
            //if (number)
            //{
            //    Console.WriteLine(number.Value);
            //}
            //else
            //{
            //    Console.WriteLine("No value!");
            //}
            Console.WriteLine(x.Value);
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            int? luckyNumber = 3;
            PrintNumber(luckyNumber);
        }

    }
}
