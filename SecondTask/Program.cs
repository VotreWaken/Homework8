using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DecimalNumber number = new DecimalNumber(42);
            Console.WriteLine(number.DecimalToBinary());
            Console.WriteLine(number.DecimalToOctal());
            Console.WriteLine(number.DecimalToHex());
        }

        struct DecimalNumber
        {
            decimal decimalValue;

            public DecimalNumber(decimal value)
            {
                decimalValue = value;
            }

            public string DecimalToBinary()
            {
                return Convert.ToString((long)decimalValue, 2);
            }

            public string DecimalToOctal()
            {
                return Convert.ToString((long)decimalValue, 8);
            }

            public string DecimalToHex()
            {
                return ((UInt64)decimalValue).ToString("X");
            }
        }
    }
}
