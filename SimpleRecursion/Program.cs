using System;

namespace SimpleRecursion
{
    class Program
    {
        static void Main()
        {
            int SimpleRecursion(int n)
            {
                if(n == 0)  // Base case
                    return -1;
                else        // Recursive case
                    return SimpleRecursion(n - 1);
            }
            Console.WriteLine(SimpleRecursion(2));
            Console.ReadLine();
        }
    }
}