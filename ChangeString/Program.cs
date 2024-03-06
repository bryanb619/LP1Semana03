using System;

namespace ChangeString
{
    class Program
    {
        /// <summary>
        /// Basic program,reads string and character passed by user, 
        /// if string has equal character to the one passed in console it replaces that for X
        /// 
        /// 1. Backup variables
        ///     -> s: used in ReadLine
        ///     -> result: used to store string elements and display final result
        ///     -> c: used to store character passed in console
        /// 
        /// 2. Input Request
        ///     -> prints request for the user
        ///     -> inputs stored in string(s) & char(c) 
        /// 
        /// 3. Loop
        ///     <param name "character">Local char</param>
        ///     -> used to loop each element of string(s)
        /// 4. if
        ///    -> when character == c, add "X" to result     
        /// 5. else
        ///     -> Add the old characters of the string to the new result string
        /// 
        /// 6. print new string! :) 
        ///     
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {

            // 1. 
            string s, result ="";
            char c; 


            // 2. 
            // Ask for a string
            Console.Write("Insert a string: ");

            // using s to store input
            s = Console.ReadLine(); 

            // Ask for a character
            Console.Write("Insert a character: ");

            // c stores converted input to char
            c = char.Parse(Console.ReadLine());


            // 3. Loops elements of s
            foreach(char character in s)
            {

                // 4.  
                if(character == c)
                {
                    // add X
                    result += "X"; 

                }


                //5.  add normal string characters
                else
                {
                    // Add a character from the orignal string
                    result += character; 

                }
            }

            // 6. print the new string
            Console.WriteLine(result); 
           
        }
    }
}
