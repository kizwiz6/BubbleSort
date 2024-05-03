namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            Console.WriteLine("Original array:");
            // PrintArray(array);
            Array.ForEach(array, x => Console.Write($"{x}, "));
            // BubbleSort(array);
            Array.Sort(array);
            Console.WriteLine("\nSorted array:");
            //PrintArray(array);
            Array.ForEach(array, Console.Write);
        }

        public static void BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j +1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Implementing my own algorithm for a bubble sort.
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[] array)
        {
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
