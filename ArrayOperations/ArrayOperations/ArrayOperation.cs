using ArrayOperations.Models;
using System.Data.SqlTypes;
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

        public static int[] Ascending(int[] array) 
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return array;
        }

        public static int[] Descending(int[] array)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return array;
        }

        public static void ReverseArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                T temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length -1 - i] = temp;
            }
        }

        private static void ReverseArray<T>(T[] array, int start, int end)
        {
            while (start < end)
            {
                T temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
