using System;

namespace HeroPerks
{
    class Program
    {
        private static void Main(string[] args)
        {

            Perks perks; 


           foreach(string s in args)
           {

                 


           }

            // 
           perks = Perks.WaterBreathing;

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
                
            }
        }
    }
}
