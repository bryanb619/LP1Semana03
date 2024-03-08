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


            
            a[0,0] = float.Parse(args[0]);
            a[0,1] = float.Parse(args[1]);

;           a[1,0] = float.Parse(args[2]);
            a[1,1] = float.Parse(args[3]);



            for (int x = 4; x < args.Length; x++)
            {
                b[x,0] = float.Parse(args[x]);
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
