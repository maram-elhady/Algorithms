namespace Linear_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linear Search: iterate through a collection one element at a time
            //Time Comlexity: O(n)

            int[] array = { 9, 5, 1, 7, 4, 2, 6, 2 };

            int index = linearSearch(array, 1);

            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found");
            }

        }
        private static int linearSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }

            }

            return -1;
        }

    }
}
