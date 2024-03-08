using System;

namespace PlayerPowers
{
    class Program
    {
        private static void Main(string[] args)
        {

            // array
            //string[] powers = new string[] {};


            // request input from user (int)
            Console.WriteLine("Enter a number: ");
            // convert to int
            int n = int.Parse(Console.ReadLine()); 

            // array of players
            string[][] players = new string[n][3];


            for(int i = 0; i < players.Length; i++)
            {
                // Request input from user (string)
                for(int j= 0; j < 3; j++)
                {
                    Console.WriteLine("Enter a power: ");
                    string pow = Console.ReadLine();

                    // add to array
                    players[i][j] = pow;
                }


            }

        }
    }
}
