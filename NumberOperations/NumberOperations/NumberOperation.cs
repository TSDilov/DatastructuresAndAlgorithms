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
    }
}
