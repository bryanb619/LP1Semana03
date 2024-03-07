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
            GameStatus status; 
            
            int gameState = 0;

            

            GameItem player1Item; 
            GameItem player2Item; 

            player1Item = (GameItem)Enum.Parse(typeof(GameItem), player1); 
            player2Item = (GameItem)Enum.Parse(typeof(GameItem), player2);



            if (player1Item == player2Item)
            {
                //gameState = 0; // Draw
                status = GameStatus.Draw; 
            }
            if (((player1Item == GameItem.Rock ) && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
            {
                //gameState = 1; // Player 1 wins
                status = GameStatus.player1Wins;
            }
            else
            {
                //gameState = 2; // Player 2 wins
                status = GameStatus.player2Wins; 
            }

            return (int)status;
        }
    }
}
