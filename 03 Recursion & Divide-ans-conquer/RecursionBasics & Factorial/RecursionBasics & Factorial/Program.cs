namespace RecursionBasics___Factorial
{
    internal class Program
    {
        // recursion = When a thing is defined in terms of itself. - Wikipedia
        //      Apply the result of a procedure, to a procedure.  
        //      A recursive method calls itself. Can be a substitute for iteration.
        //      Divide a problem into sub-problems of the same type as the original.
        //      Commonly used with advanced sorting algorithms and navigating trees

        //iteration: repetation of internal process , recursion:repatation of a procedure

        //      Advantages:
        //      ----------
        //      easier to read/write
        //      easier to debug

        //      Disadvantages:
        //      ----------
        //      sometimes slower
        //      uses more memory
        static void Main(string[] args)
        {
            walk(5);
            Console.WriteLine(power(2, 8));
            Console.WriteLine(factorial(7));
        }

        private static int power(int baseNum, int exponent)
        {
            if (exponent < 1) return 1; //base case
            return baseNum * power(baseNum, exponent - 1 ); //recursive case
        }

        private static int factorial(int num)
        {
            if (num < 1) return 1; //base case
            return num * factorial(num -1); //recursive case

        }

        //private static void walk(int steps)  //iteration
        //{
        //    for (int i = 0; i < steps; i++) 
        //    {
        //        Console.WriteLine("You take a step");
        //    }
        //}
        private static void walk(int steps) //recursion
        {
            if(steps < 1) return; //baseCase
            Console.WriteLine("You take a step!");
            walk(steps - 1); //recursive case

        }
    }
}
