﻿namespace Datastructures.SortingAlgorithms
{
    public class CustomSort
    {
        public static List<T> SelectionSortAlgorithm<T>(IEnumerable<T> collection) where T : IComparable<T>
        {
            var list = new List<T>(collection);
            var numberOfItems = list.Count;
            for (int i = 0; i < numberOfItems - 1; i++) 
            {
                var minIndex = i;
                for (int j = i + 1; j < numberOfItems; j++) 
                {
                    if (list[j].CompareTo(list[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                T temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;
            }

            return list;
        }

        public static List<T> InsertionSortAlgorithm<T>(IEnumerable<T> collection) where T : IComparable<T>
        {
            var list = new List<T>(collection);
            var numberOfItems = list.Count;

            for (int i = 1; i < numberOfItems; i++)
            {
                T key = list[i];
                var j = i - 1;
                while (j >= 0 && list[j].CompareTo(key) > 0)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                list[j + 1] = key;
            }

            return list;
        }

        public static List<T> HeapSortAlgorithm<T>(IEnumerable<T> collection) where T : IComparable<T>
        {
            var list = new List<T>(collection);
            var numberOfItems = list.Count;

            for (int i = numberOfItems / 2 - 1; i >= 0; i--)
            {
                Heapify(list, numberOfItems, i);
            }

            for (int i = numberOfItems - 1; i >= 0; i--)
            {
                T temp = list[0];
                list[0] = list[i];
                list[i] = temp;

                Heapify(list, i, 0);
            }

            return list;
        }

        public static List<T> MergeSortAlgorithm<T>(IEnumerable<T> collection) where T : IComparable<T>
        {
            var list = new List<T>(collection);
            var numberOfItems = list.Count;

            if (numberOfItems <= 1)
            { 
                return list; 
            }

            var middle = numberOfItems / 2;
            var leftList = new List<T>(list.GetRange(0, middle));
            var rightList = new List<T>(list.GetRange(middle, numberOfItems - middle));

            leftList = MergeSortAlgorithm(leftList);
            rightList = MergeSortAlgorithm(rightList);

            return Merge(leftList, rightList);
        }

        public static List<T> QuickSortAlgorithm<T>(IEnumerable<T> collection) where T : IComparable<T>
        {
            var list = new List<T>(collection);
            var numberOfItems = list.Count;

            if (numberOfItems <= 1)
            {
                return list;
            }

            var pivotIndex = list.Count / 2;
            T pivotValue = list[pivotIndex];
            var leftList = new List<T>();
            var rightList = new List<T>();

            for (int i = 0; i < numberOfItems; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }

                if (list[i].CompareTo(pivotValue) <= 0) 
                {
                    leftList.Add(list[i]);
                }
                else 
                {
                    rightList.Add(list[i]);
                }
            }

            var sortedList = new List<T>();
            sortedList.AddRange(QuickSortAlgorithm(leftList));
            sortedList.Add(pivotValue);
            sortedList.AddRange(QuickSortAlgorithm(rightList));

            return sortedList;
        }

        private static List<T> Merge<T>(List<T> leftList, List<T> rightList) where T : IComparable<T>
        {
            var result = new List<T>();
            int i = 0, j = 0;
            var leftCount = leftList.Count;
            var rightCount = rightList.Count;

            while (i < leftCount && j < rightCount)
            {
                if (leftList[i].CompareTo(rightList[j]) <= 0)
                {
                    result.Add(leftList[i]);
                    i++;
                }
                else 
                {
                    result.Add(rightList[j]);
                    j++;
                }
            }

            while (i < leftCount)
            {
                result.Add(leftList[i]);
                i++;
            }

            while (j < rightCount)
            {
                result.Add(rightList[j]);
                j++;
            }

            return result;
        }

        private static void Heapify<T>(List<T> list, int numberOfItems, int i) where T : IComparable<T>
        {
            var largest = i;
            var left = 2 * i + 1;
            var right = 2 * i + 2;

            if (left < numberOfItems && list[left].CompareTo(list[largest]) > 0) 
            {
                largest = left;
            }

            if (right < numberOfItems && list[right].CompareTo(list[largest]) > 0)
            {
                largest = right;
            }

            if (largest != i)
            {
                T swap = list[i];
                list[i] = list[largest];
                list[largest] = swap;

                Heapify(list, numberOfItems, largest);
            }
        }
    }
}
