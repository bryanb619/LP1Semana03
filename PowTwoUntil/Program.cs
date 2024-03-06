using System;

namespace PowTwoUntil
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Calling void twice :(
            PowersOf2Until5();
            PowersOf2Until5(); 
        }

        // new method
        /// <summary>
        ///  This method writes the number 1 to 32
        ///  the for shifts i << 1, so first 1 ... 32
        /// </summary>
        private static void PowersOf2Until5()
        {

            for (int i= 1; i<= (1<<5); i = i<< 1)
            {
                // writes a decimal value
                Console.WriteLine(i);

            }
 

        }
    }
}
