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
            // 'd' = destroyer
            // 'b' = battleship
            // 's' = submarine
            // 'c' = carrier
            // 'r' = cruiser

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
        public void updateBoard(string guess, char status) {
            // parse guess
            board[YLocation, XLocation] = status;
        }

        public Boolean isValidGuess(string guess) {
            // parse guess  
            // valid guess is either 'e' or ship (not miss or hit)
            return true;
        }

        public Boolean isHit(string guess) {
            // parse guess
            // return true if board spot is a ship

        }

        public int getShip(string guess) {
            // parse guess
            // return correct ship number/index
        }

        // parse X

        // parse Y

        // board of a player's hits and misses (guesses) on other player's ships
        public void displayGuessBoard() {
            Console.WriteLine("\t     A B C D E F G H I J");
            Console.WriteLine("\t    ---------------------");
            for (int i = 0; i < 10; i++) {
                Console.Write("\t");
                if (i != 9)
                {
                    Console.Write(" ");
                }
                Console.Write((i + 1) + " |");

                for (int j = 0; j < 10; j++)
                {
                    if (board[i,j] == 'h') {
                        Console.Write(" X");
                    }
                    else if (board[i,j] == 'm') {
                        Console.Write(" O");
                    }
                    else {
                        Console.Write(" ~");
                    }
                }
                Console.Write(" |\n");
            }
            Console.WriteLine("\t    ---------------------");
        }

        // board of player's ship placement and other player's hits and misses (gueses)
        public void displayShipBoard()
        {
            Console.WriteLine("\t     A B C D E F G H I J");
            Console.WriteLine("\t    ---------------------");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t");
                if (i != 9) {
                    Console.Write(" ");
                }
                Console.Write((i + 1) + " |");

                for (int j = 0; j < 10; j++)
                {
                    if (board[i, j] == 'e')
                    {
                        Console.Write(" ~");
                    }
                    else if (board[i, j] == 'h')
                    {
                        Console.Write(" X");
                    }
                    else if (board[i, j] == 'm')
                    {
                        Console.Write(" O");
                    }
                    else if (board[i, j] == 'c')
                    {
                        Console.Write(" C");
                    }
                    else if (board[i, j] == 's')
                    {
                        Console.Write(" S");
                    }
                    else if (board[i, j] == 'd')
                    {
                        Console.Write(" D");
                    }
                    else if (board[i, j] == 'b')
                    {
                        Console.Write(" B");
                    }
                    else if (board[i, j] == 'r')
                    {
                        Console.Write(" R");
                    }
                }
                Console.Write(" |\n");
            }
            Console.WriteLine("\t    ---------------------");
        }
    }
}
