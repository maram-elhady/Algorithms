
namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //swapped if they are not in order.
            //small data set = okay-ish
            //large data set = BAD (plz don't)

            //	Complexity: Quadratic time O(n^2)

            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            Bubble_Sort(array);

            for(int i = 0; i<array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        private static void Bubble_Sort(int[] array)
        {
            for(int i = 0;i<array.Length;i++)
            {
                for (int j = 0;j<array.Length-i-1;j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
