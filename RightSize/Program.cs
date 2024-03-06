using System;

namespace RightSize
{
    class Program
    {

        /// <summary>
        ///  Basic programs, iterates over arguments passed in console
        /// 
        ///  1. backup variable -> used in for loop
        ///  2. foreach -> checks each string in args array
        ///  3. continue if argument size is bigger then 3
        ///  4. STOP CODE when argument > 6 and return (STOP CODE)
        ///         -> return position not ideal
        ///  5. print only args(strings) with Length > 3
        ///  6. increment i always when loop reaches iteration end
        /// </summary>
        /// <param name="args">Not used</param>
        private static void Main(string[] args)
        {

            // 1.
            int i = 0;

            // 2. iterate over strings in args -> []
            foreach(string s in args)
            {
                
                // 3. check if argument size is bigger then 3
                if (s.Length > 3)
                {

                    // 4. check if has more than 6 elements
                    if(s.Length > 6)
                    {
                        return; 
                    }

                    // 5.  
                    Console.WriteLine(args[i]);
                } 

                // 6. increment i
                i++;
                
            }
                

        }
    }
}
