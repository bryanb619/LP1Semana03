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


            PowersEnum[][] players = new PowersEnum[n][];



            for(int i = 0; i < players.Length; i++)
            {

                players[i] = new PowersEnum[3];

            

                // Request input from user (string)
                for(int j= 0; j < 3; j++)
                {

                    Console.Write($"Player {i+1} enter a power: ");

                    string pow = Console.ReadLine();

              
                    
                    //p_power = (Powers)Enum.Parse(typeof(Powers), pow);

                    if(pow == "Fly")
                    {
                        players[i][j] = PowersEnum.Fly;
                    }
                    else if(pow == "XRayVision")
                    {
                        players[i][j] = PowersEnum.XRayVision;
                    }
                    else if(pow == "SuperStrength")
                    {
                        players[i][j] = PowersEnum.SuperStrength;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Power");
                    }

                }
                
            }

        }
        
    }
}
