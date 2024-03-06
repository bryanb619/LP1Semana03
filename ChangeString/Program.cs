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
            string s;
            char c; 



            Console.Write("Insert a string: ");

            s = Console.ReadLine(); 

            Console.Write("Insert a character: ");

            c = char.Parse(Console.ReadLine());


            //

            string x = "X";

            foreach(char character in s)
            {
                if(character == c)
                {


                }
            }
           
        }
    }
}
