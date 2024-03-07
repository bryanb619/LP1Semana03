using System;

namespace HeroPerks
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Perks perks;

            //Perks perk;

            int i = 0; 

            string[] perksArray = new string[Enum.GetNames(typeof(Perks)).Length]; 
                  
            // 
           //perks = Perks.WaterBreathing;

            foreach(string perkName in Enum.GetNames(typeof(Perks)))
            {

                perksArray[i] = perkName;
                Console.WriteLine(perksArray[i]); 

                i++; 

                
                
            }

             

        /*

            foreach(string s in args)
            {
            /*
                switch(perks)
                {
                    case Perks.WaterBreathing:
                    {

                        break; 
                    }

                    case Perks.Stealth:
                    {
                        break; 
                    }

                    case Perks.AutoHeal:
                    {
                        break; 
                    }

                    case Perks.DoubleJump:
                    {
                        break; 
                    }
                } */
        }

            //perk = (Perks)Enum.Parse(typeof(Perks), s); 

        
    }
}
