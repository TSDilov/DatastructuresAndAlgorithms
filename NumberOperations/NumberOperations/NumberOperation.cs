using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumberOperations
{
    public static class NumberOperation
    {
        public static int CountWaysForClimbing(int n)
        {
            if (n <= 1) return 1;

            var dynamic = new int[n + 1];
            dynamic[0] = 1;
            dynamic[1] = 1;

            for (int i = 2; i <= n; i++) 
            {
                dynamic[i] = dynamic[i - 1] + dynamic[i - 2];
            }

            return dynamic[n];
        }

        public static int Factorial(int number)
        {
            if (number == 1) { return 1; }

            return number * Factorial(number - 1);
        }

        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int GetGCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2) num1 -= num2;
                if (num2 > num1) num2 -= num1;
            }

            return num1;
        }

        public static int GetLCM(int num1, int num2)
        {
            return (num1 * num2) / GetGCD(num1, num2);
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}
