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
            
            GameItem play1Item; 
            GameItem play2Item; 

            play1Item = (GameItem)Enum.Parse(typeof(GameItem), player1); 
            play2Item = (GameItem)Enum.Parse(typeof(GameItem), player2);


            if (play1Item == play2Item)
            {
                //gameState = 0; // Draw
                status = GameStatus.Draw; 
            }
            else if (((play1Item == GameItem.Rock ) && (play2Item == GameItem.Scissors)) ||
                ((play1Item == GameItem.Scissors) && (play2Item == GameItem.Paper)) ||
                ((play1Item == GameItem.Paper) && (play2Item == GameItem.Rock)))
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
