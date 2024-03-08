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

           


            // A array values
            a[0,0] = float.Parse(args[0]);
            a[0,1] = float.Parse(args[1]);
;           a[1,0] = float.Parse(args[2]);
            a[1,1] = float.Parse(args[3]);

            // B array values
            b[0,0] = float.Parse(args[4]);
            b[1,0] = float.Parse(args[5]);   
        
            
            for(int i = 0; i < 2; i++)
            {
                float CalcResult = 0F; 
                for(int j = 0; j < 2 ; j++)
                {
                    // Multiplication
                    CalcResult += a[i, j] * b[j, 0];
                    
                }
                Console.WriteLine(CalcResult);
            }

           
        }
    }
}
