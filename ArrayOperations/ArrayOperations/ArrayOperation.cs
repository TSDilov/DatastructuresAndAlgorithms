using ArrayOperations.Models;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace ArrayOperations
{
    public class ArrayOperation
    {
        public static int[] RotateArray(int[] array, int pivot)
        {
            if (pivot < 0 || pivot >= array.Length)
            {
                return array; 
            }

            pivot = pivot % array.Length;
            ReverseArray(array, 0, pivot - 1);
            ReverseArray(array, pivot, array.Length - 1);
            ReverseArray(array, 0, array.Length - 1);

            return array;
        }

        private static void ReverseArray(int[] array, int start, int end)
        {
            while (start < end)
            {
                var temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }

        public static bool FindMatchingPairsThatSumTheLookingInt(int[] array, int lookingSum)
        {
            var seenNumbers = new HashSet<int>();
            foreach (var number in array) 
            {
                var complement = lookingSum - number;
                if (seenNumbers.Contains(complement)) {  return true; }
                seenNumbers.Add(number);
            }

            return false;
        }
    }
}
