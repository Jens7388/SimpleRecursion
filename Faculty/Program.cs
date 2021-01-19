using System;

namespace Faculty
{
    class Program
    {
        static void Main()
        {
            for(int n = 1; n <= 21; n++)
            {
                Console.WriteLine(Faculty(n));
            }
            Console.ReadLine();
        }

        private static long Faculty(long n)
        {
            if(n == 1)
            {
                return n;
            }
            else
            {
                return n * Faculty(n-1);
            }
        }
    }
}
