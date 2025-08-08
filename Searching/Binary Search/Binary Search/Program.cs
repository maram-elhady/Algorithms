
namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Binary Search: Search algorithm that finds the position of a target value within a sorted array.
            //       Half of the array is eliminated during each "step"
            //Complexity :O(log n)
            int[] array = new int[1000000];
            int target = 777777;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            //int index = Array.BinarySearch(array, target);
            int index = binarySearch(array, target);

            if (index == -1)
            {
                Console.WriteLine(target + " not found");
            }

            else
            {
                Console.WriteLine("Element found at " + index);
            }
        }

        private static int binarySearch(int[] array, int target)
        {
            int low = 0;
            int high = array.Length;    

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int value = array[mid];

                Console.WriteLine("middle "+value);

                if(value < target)
                    low = mid + 1;
                else if (value > target) 
                    high = mid - 1;
                else return mid; //target found
            }

            return -1; //not found
        }
    }
}
