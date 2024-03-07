using System;

namespace HeroPerks
{

    class Program
    {
        private static void Main(string[] args)
        {

            Perks perks; 

            int i = 0, j = 0;


            string[] perksArray = new string
            [Enum.GetNames(typeof(Perks)).Length]; 

            string[] argumentStrings = new string
            [args.Length];
                  
        
            foreach(string perkName in Enum.GetNames(typeof(Perks)))
            {

                perksArray[i] = perkName;
                //Console.WriteLine(perksArray[i]); 

                i++; 
            }
        }

    }
}
