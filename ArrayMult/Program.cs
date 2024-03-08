using System;
using System.Globalization;

namespace ArrayMult
{
    class Program
    {
        private static void Main(string[] args)
        {

            // arrays 
            float[,] a = new float[2, 2];
            float[,] b = new float[2, 1];

            float CalcResult = 0F; 

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
    
        
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2 ; j++)
                {
                    
                    CalcResult += a[i, j] * b[j, 0];
                    
                }
            }



            Console.WriteLine(CalcResult);
        }
    }
}
