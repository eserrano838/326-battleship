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
        public void updateBoard(int XLocation, int YLocation, char status) {
            board[YLocation, XLocation] = status;
        }

        public Boolean isValidGuess(int xLocation, int yLocation) {
            // valid guess is either 'e' or ship (not 'm' or 'h')
            if (board[xLocation, yLocation] == 'h')
            {
                return false;
            }else if (board[xLocation, yLocation] == 'm')
            {
                return false;
            }else
            {
                return true;
            }            
        }

        public Boolean isHit(int xLocation, int yLocation) {
            // return true if board spot is a ship (so not 'e','h','m')
            if (board[xLocation, yLocation] == 'e')
            {
                return false;
            }
            else if(board[xLocation, yLocation] == 'h')
            {
                return false;
            }else if (board[xLocation, yLocation] == 'm')
            {
                return false;
            }else
            {
                return true;
            }

        }

        public int getShip(int xLocation, int yLocation) {
            // parse guess
            // return correct ship number/index
                int x = xLocation;
                int y = yLocation;

                if ((board[x, y] == 'd')) { return 4; }
                else if ((board[x, y] == 's')) { return 3; }
                else if ((board[x, y] == 'r')) { return 2; }
                else if ((board[x, y] == 'b')) { return 1; }
                else if ((board[x, y] == 'c')) { return 0; }
                else { return 5; }

        }



        public int ParseX(char xGuess)
        {
            return xGuess - '0';
        }

        // parse Y
        public int ParseY(char yGuess)
        {
            if (yGuess == 'A'){
                return 0;
            }
            else if (yGuess == 'B'){
                return 1;
            }
            else if (yGuess == 'C'){
                return 2;
            }
            else if (yGuess == 'D'){
                return 3;
            }
            else if (yGuess == 'E'){
                return 4;
            }
            else if (yGuess == 'F'){
                return 5;
            }
            else if (yGuess == 'G'){
                return 6;
            }
            else if (yGuess == 'H')
            {
                return 7;
            }
            else if (yGuess == 'I')
            {
                return 8;
            }
            else
            {
                return 9;
            }

        }

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
