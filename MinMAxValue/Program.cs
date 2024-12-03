using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                int n1 = int.MinValue;
                int n2 = int.MaxValue;
                sbyte n3 = sbyte.MinValue;
                sbyte n4 = sbyte.MaxValue;
                decimal n5 = decimal.MinValue;
                decimal n6 = decimal.MaxValue;

                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine(n3);
                Console.WriteLine(n4);
                Console.WriteLine(n5);
                Console.WriteLine(n6);




            }
        }
    }
}