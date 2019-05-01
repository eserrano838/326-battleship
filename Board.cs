using System;
namespace BattleShip
{
    public class Board
    {
        public char[,] board = new char[10, 10];

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
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    board[i, j] = 'e';
                }
            }
        }

        // updates point on board
        public void updateBoard(int x, int y, char status)
        {
            board[y, x] = status;
        }

        // returns true if guess is either an 'e' or a ship
        // returns false if guess is a hit or a miss (already guessed)
        public Boolean isValidGuess(int x, int y)
        {
            char guess = board[y, x];
            // valid guess is either 'e' or ship (not 'm' or 'h')
            if (guess == 'h' || guess == 'm') {
                return false;
            } else {
                return true;
            }
        }

        // returns true if board spot is a ship
        public Boolean isHit(int x, int y)
        {
            char guess = board[y, x];
            // return true if board spot is a ship (so not 'e','h','m')
            if (guess == 'e' || guess == 'h' || guess == 'm') {
                return false;
            } else {
                return true;
            }
        }

        // returns the correct ship index at given coordinate
        public int getShip(int x, int y)
        {
            char guess = board[y, x];
            switch(guess) {
                case 'd':
                    return 4;
                case 's':
                    return 3;
                case 'r':
                    return 2;
                case 'b':
                    return 1;
                default:
                    return 0;
            }
        }

        // board of a player's hits and misses (guesses) on other player's ships
        public void displayGuessBoard()
        {
            Console.WriteLine("\t     A B C D E F G H I J");
            Console.WriteLine("\t    ---------------------");
            for (int i = 0; i < 10; i++) {
                Console.Write("\t");
                if (i != 9) {
                    Console.Write(" ");
                }
                Console.Write((i + 1) + " |");

                for (int j = 0; j < 10; j++) {
                    if (board[i, j] == 'h') {
                        Console.Write(" X");
                    } else if (board[i, j] == 'm') {
                        Console.Write(" O");
                    } else {
                        Console.Write(" ~");
                    }
                }
                Console.Write(" |\n");
            }
            Console.WriteLine("\t    ---------------------");
        }

        // board of player's ship placement and other player's hits and misses (guesses)
        public void displayShipBoard()
        {
            Console.WriteLine("\t     A B C D E F G H I J");
            Console.WriteLine("\t    ---------------------");
            for (int i = 0; i < 10; i++) {
                Console.Write("\t");
                if (i != 9) {
                    Console.Write(" ");
                }
                Console.Write((i + 1) + " |");

                for (int j = 0; j < 10; j++) {
                    if (board[i, j] == 'e') {
                        Console.Write(" ~");
                    } else if (board[i, j] == 'h') {
                        Console.Write(" X");
                    } else if (board[i, j] == 'm') {
                        Console.Write(" O");
                    } else if (board[i, j] == 'c') {
                        Console.Write(" C");
                    } else if (board[i, j] == 's') {
                        Console.Write(" S");
                    } else if (board[i, j] == 'd') {
                        Console.Write(" D");
                    } else if (board[i, j] == 'b') {
                        Console.Write(" B");
                    } else if (board[i, j] == 'r') {
                        Console.Write(" R");
                    }
                }
                Console.Write(" |\n");
            }
            Console.WriteLine("\t    ---------------------");
        }

        // displays board with character values (used for debugging/testing)
        public void displayReal()
        {
            Console.WriteLine("\t     A B C D E F G H I J");
            Console.WriteLine("\t    ---------------------");
            for (int i = 0; i < 10; i++) {
                Console.Write("\t");
                if (i != 9) {
                    Console.Write(" ");
                }
                Console.Write((i + 1) + " |");

                for (int j = 0; j < 10; j++) {
                    Console.Write(" " + board[i,j]);
                }
                Console.Write(" |\n");
            }
            Console.WriteLine("\t    ---------------------");
        }
    }
}