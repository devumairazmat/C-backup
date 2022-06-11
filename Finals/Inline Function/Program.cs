
using System;

namespace inline_function
{
    class Program
    {
        static void Main(string[] args)
        {
            void sum(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            sum(7, 11);
        }
    }
}