using System;
namespace BattleShip
{
    public class Board
    {
        public char[,] board = new char[10,10];

        public Board()
        {
            // 'e' = empty
            // 'h' = hit
            // 'm' = miss
            // 's' = ship

            // initialize board to all 'e'
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i,j] = 'e';
                }
            }
        }

        // updates point on board
        public void updateBoard(int XLocation, int YLocation, char status) {
            board[YLocation, XLocation] = status;
        }

        // board of a player's hits and misses (guesses) on other player's ships
        public void displayGuessBoard() {
            Console.WriteLine(" A B C D E F G H I J");
            for (int i = 0; i < 10; i++) {
                Console.Write(i + 1);
                for (int j = 0; j < 10; j++)
                {
                    if (board[i,j] == 'h') {
                        Console.Write(" X");
                    }
                    else if (board[i,j] == 'm') {
                        Console.Write(" O");
                    }
                    else {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }
            
        }

        // board of player's ship placement and other player's hits and misses (gueses)
        public void displayShipBoard()
        {
            Console.WriteLine(" A B C D E F G H I J");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < 10; j++)
                {
                    if (board[i, j] == 'e')
                    {
                        Console.Write("  ");
                    }
                    else if (board[i, j] == 'h')
                    {
                        Console.Write(" X");
                    }
                    else if (board[i, j] == 'm')
                    {
                        Console.Write(" O");
                    }
                    else if (board[i, j] == 's')
                    {
                        Console.Write(" S");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
