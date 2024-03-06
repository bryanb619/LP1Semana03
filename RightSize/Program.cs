using System;

namespace RightSize
{
    class Program
    {

        /// <summary>
        ///  Basic programs, 
        /// </summary>
        /// <param name="args">Not used</param>
        private static void Main(string[] args)
        {

            int i = 0;

            
            foreach(string s in args)
            {

               
                // print args with lenght > 3
                if (s.Length > 3)
                {

                    if(s.Length > 6)
                    {
                        return; 
                    }

                    Console.WriteLine(args[i]);
                } 

                
                i++;
                
            }
                

        }
    }
}
