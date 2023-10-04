using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class OperationWithRecursion
    {
        public static int SumOfDigits(int num)
        {
            if (num != 0)
            {
                return (num % 10 + SumOfDigits(num / 10));
            } 

            return 0;
        }

        public static int BinaryConversion(int num)
        {
            int bin;
            if (num != 0) 
            {
                bin = (num % 2) + 10 * BinaryConversion(num / 2);
                Console.Write(bin);
                return 0;
            }

            return 0;
        }

        public static double Power(double number, int exponent)
        {
            if (exponent < 0) throw new ArgumentException("The exponent can not be negative!");
            else if (exponent == 1) { return number; }
            else if (exponent == 0) { return 1; }
            else { return number * Power(number, exponent - 1); }
        }
    }
}
