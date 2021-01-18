using System;
using System.Diagnostics;

namespace Fionacci
{
    class Program
    {
        static void Main()
        {
            
            FibonacciSequence();
        }

        private static void FibonacciSequence()
        {
            for(int n = 2; n < 45; n++)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                int result = Fibonacci(n);
                timer.Stop();
                Console.WriteLine($"{n}, {result} Elapsed time: {timer.Elapsed}");
                timer.Reset();            
            }
            Console.ReadLine();
        }

        private static int Fibonacci(int n)
        {
            if(n < 2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}