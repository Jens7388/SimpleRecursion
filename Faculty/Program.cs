using System;

namespace Faculty
{
    class Program
    {
        static void Main()
        {
            for(int n = 1; n < 15; n++)
            {
                Console.WriteLine(Faculty(n));
            }
            Console.ReadLine();
        }

        private static int Faculty(int n)
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
