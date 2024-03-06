using System;

namespace PowTwoUntil
{
    class Program
    {
        private static void Main(string[] args)
        {
            for (int i= 0; i<= (1<<5); i = i<< 1)
            {
                Console.WriteLine("Hello, World!");

            }
 
        }
    }
}
