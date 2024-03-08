using System;

namespace PlayerPowers
{
    class Program
    {
        private static void Main(string[] args)
        {


            // request input from user (int)
            Console.WriteLine("Enter a number: ");

            // convert to int
            int n = int.Parse(Console.ReadLine()); 


            PowersEnum[][] players = new PowersEnum[n][3];

           // Powers power; 


            for(int i = 0; i < players.Length; i++)
            {
                // Request input from user (string)
                for(int j= 0; j < 3; j++)
                {

                    Console.WriteLine($"Player {i+1} enter a power: ");

                    string pow = Console.ReadLine();
                    
                    //p_power = (Powers)Enum.Parse(typeof(Powers), pow);

                    switch(p_power)
                    {

                        case Powers.Fly:

                            players[i][j] ^= Powers.Fly:;
                            break;

                        case Powers.XRayVision:
               
                            players[i][j] ^= Powers.XRayVision;
                            break;

                        case Power.SuperStrength:
                
                            players[i][j] ^= Power.SuperStrength;
                            break;


                        default:
                            Console.WriteLine("Invalid Power");
                            break;
                    }
                 
                }
                Console.WriteLine(players[i][j]);
            }
/*

            for(int i = 0; i < players.Length; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(players[i] 
                    )
                    Console.WriteLine(players[i][j]);
                }
            }

        }~
        */
    }
}
