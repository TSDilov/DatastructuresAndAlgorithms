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

        public static int BinarySearch(int[] array, int target)
        {
            Array.Sort(array);
            return BinarySearchRecursive(array, target, 0, array.Length - 1);
        }

        public static void QuickSortAlgorithm(int[] array, int left, int right)
        {
            if (left < right)
            {
                var pivotIndex = Partition(array, left, right);
                QuickSortAlgorithm(array, left, pivotIndex - 1);
                QuickSortAlgorithm(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            var pivot = array[right];
            var i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static int BinarySearchRecursive(int[] array, int target, int left, int right)
        {
            try
            {
                var middle = left + (right - left) / 2;
                if (array[middle] == target)
                {
                    return middle;
                }

                if (target < array[middle])
                {
                    return BinarySearchRecursive(array, target, left, middle - 1);
                }

                return BinarySearchRecursive(array, target, middle + 1, right);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
