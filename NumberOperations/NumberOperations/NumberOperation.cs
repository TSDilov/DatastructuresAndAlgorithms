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
    }
}
