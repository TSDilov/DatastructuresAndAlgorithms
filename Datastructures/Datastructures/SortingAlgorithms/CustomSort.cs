namespace Datastructures.SortingAlgorithms
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
    }
}
