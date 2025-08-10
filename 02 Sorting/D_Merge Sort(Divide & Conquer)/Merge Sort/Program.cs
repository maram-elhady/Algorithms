

namespace Merge_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // merge sort = recursively divide array in 2, sort, re - combine
            // Run-time complexity = O(n Log n)
            // Space complexity    = O(n)

            int[] array = { 8, 2, 5, 3, 4, 7, 6, 1 };

            Merge_Sort(array);

            foreach (int i in array)
                Console.Write(i + " ");

        }

        private static void Merge_Sort(int[] array)
        {
            int length = array.Length;
            if (length <= 1) return; //base case

            int middle = length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[length - middle];

            int i = 0; //left array
            int j = 0; //right array

            for (; i < length; i++)
            {
                if (i < middle)
                {
                    leftArray[i] = array[i];
                }
                else
                {
                    rightArray[j] = array[i];
                    j++;
                }
            }
            Merge_Sort(leftArray);
            Merge_Sort(rightArray);
            merge(leftArray, rightArray, array);
        }

        private static void merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int i = 0, l = 0, r = 0; //indices

            //check the conditions for merging
            while (l < leftSize && r < rightSize)
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }
            while (l < leftSize)
            {
                array[i] = leftArray[l];
                i++;
                l++;
            }
            while (r < rightSize)
            {
                array[i] = rightArray[r];
                i++;
                r++;

            }
        }
    }
}
