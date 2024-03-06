using System;

namespace ChangeString
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            string s, result ="";
            char c; 



            Console.Write("Insert a string: ");

            s = Console.ReadLine(); 

            Console.Write("Insert a character: ");

            c = char.Parse(Console.ReadLine());


            //

          

            foreach(char character in s)
            {
                if(character == c)
                {

                    result += "X"; 

                }

                else
                {
                    result += character; 

                }
            }

            Console.WriteLine(result); 
           
        }
    }
}
