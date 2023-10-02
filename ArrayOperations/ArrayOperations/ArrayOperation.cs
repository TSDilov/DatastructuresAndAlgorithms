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

        public static T GetMajorityElement<T>(T[] array)
        {
            var dictionary = new Dictionary<T, int>();

            foreach (var element in array)
            {
                if (!dictionary.ContainsKey(element))
                {
                    dictionary.Add(element, 1);
                }
                else
                {
                    dictionary[element]++;
                }
            }

            T majorityElement = default(T);
            var maxCount = 0;

            foreach (var countedElement in dictionary)
            {
                if (countedElement.Value > maxCount)
                {
                    majorityElement = countedElement.Key;
                    maxCount = countedElement.Value;
                }
            }

            if (maxCount > array.Length / 2)
            {
                return majorityElement;
            }
            else
            {
                throw new InvalidOperationException("THere is no majority element!");
            }
        }

        public static int[] MergeArrays(int[] firstArray, int[] secondArray)
        {
            Array.Sort(firstArray);
            Array.Sort(secondArray);
            var firstLength = firstArray.Length;
            var secondLength = secondArray.Length;
            var mergedArray = new int[firstLength + secondLength];

            int i = 0, j = 0, k = 0;
            while (i < firstLength && j < secondLength)
            {
                if (firstArray[i] < secondArray[j])
                {
                    mergedArray[k++] = firstArray[i++];
                }
                else
                {
                    mergedArray[k++] = secondArray[j++];
                }
            }

            while (i < firstLength)
            {
                mergedArray[k++] = firstArray[i++];
            }

            while (j < secondLength)
            {
                mergedArray[k++] = secondArray[j++];
            }

            return mergedArray;
        }

        public static void MinAndMaxSwap(int[] array)
        {
            int min = 0, max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[min] > array[i])
                {
                    min = i;
                }

                if (array[max] < array[i])
                {
                    max = i;
                }
            }

            var temp = array[min];
            array[min] = array[max];
            array[max] = temp;
        }

        public static void Move(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    MoveZeroToEnd(array, i);
                }
            }
        }

        private static void MoveZeroToEnd(int[] array, int index)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                var temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
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
