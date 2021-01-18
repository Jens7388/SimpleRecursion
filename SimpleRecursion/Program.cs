using System;

namespace SimpleRecursion
{
    class Program
    {
        static void Main()
        {   
            Console.WriteLine(SimpleRecursion(3)); 
            Console.ReadLine();
        }

        private static int SimpleRecursion(int n)
        {
            if(n == 0)  // Base case             
            {
                return -1;
            }
            else        // Recursive case                 
            {
                return SimpleRecursion(n - 1);
            }
        }
    }
}