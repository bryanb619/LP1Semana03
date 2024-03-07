using System;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        /// <summary>
        ///  Backup variable
        ///  -> gameState "guarantees" no lost return in code
        /// 
        /// </summary>
        /// <param name="player1">first string</param>
        /// <param name="player2">second string</param>
        /// <returns>The game state</returns>
        private static int RockPaperScissors(string player1, string player2)
        {
            
            
            int gameState = 0; 


            if (player1 == player2)
            {
                gameState = 0; // Draw
            }
            if (((player1 == "Rock") && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
            {
                gameState = 1; // Player 1 wins
            }
            else
            {
                gameState = 2; // Player 2 wins
            }

            return gameState; 
        }
    }
}
