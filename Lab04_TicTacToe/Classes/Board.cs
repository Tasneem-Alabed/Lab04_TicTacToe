using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{

            //TODO: Output the board to the console
            {
                for (int x = 0; x < GameBoard.GetLength(0); x++)
                {
                    for (int j = 0; j < GameBoard.GetLength(1); j++)
                    {
                        Console.Write($"|{GameBoard[x, j]}|");
                    }
                    Console.WriteLine();
                }
            }


        }
	}
}
