using System;

namespace BattleShip
{
    public class Project
    {
        public static void Main(String[] args)
        {
            string player1name;
            string player2name;
            int playerTurn = 1;
            Console.WriteLine(" ============================================");
            Console.WriteLine(" ===========Welcome to BattleShip!===========");
            Console.WriteLine(" ============================================\n");

            Console.Write(" Enter Player 1's name: ");
            player1name = Console.ReadLine();

            Console.Write(" Enter Player 2's name: ");
            player2name = Console.ReadLine();

            // create players
            Player player1 = new Player { Name = player1name };
            Player player2 = new Player { Name = player2name };
            Console.WriteLine();

            // initialize players' ship locations
            player1.SetFleetLocations1();
            player2.SetFleetLocations2();

            // to ensure player 2 doesnt see player 1's ship locations
            Console.Write(player2.Name + " look away. (Enter 'Q' to quit game) ");
            string quit = Console.ReadLine();
            Console.WriteLine();

            while (!HasFinished(player1, player2) && quit != "Q") {
                if (playerTurn == 1) {

                    playerTurn = PlayTurn(player1, player2, playerTurn);

                    // to ensure player 1 doesnt see player 2's ship locations
                    Console.Write(player1.Name + " look away. (Enter 'Q' to quit game) ");
                    quit = Console.ReadLine();
                    Console.WriteLine();
                } else {

                    playerTurn = PlayTurn(player2, player1, playerTurn);

                    // to ensure player 2 doesnt see player 1's ship locations
                    Console.Write(player2.Name + " look away. (Enter 'Q' to quit game) ");
                    quit = Console.ReadLine();
                    Console.WriteLine();
                }
            }

            // display winner
            if (player1.fleet.allSunk() || player1.fleet.TotalHits() > player2.fleet.TotalHits()) {
                Console.WriteLine(player1.Name + " won!!!");
            } else if (player2.fleet.allSunk() || player2.fleet.TotalHits() > player1.fleet.TotalHits()) {
                Console.WriteLine(player2.Name + " won!!!");
            } else {
                Console.WriteLine("Tie!!!");
            }
        }

        // returns true if player 1's or player 2's ships have all been sunk
        public static Boolean HasFinished(Player p1, Player p2)
        {
            return (p1.fleet.allSunk() || p2.fleet.allSunk());
        }

        // plays a turn for playerA
        // returns correct updated player turn
        public static int PlayTurn(Player playerA, Player playerB, int playerTurn)
        {
            // display player's boards
            playerA.guessBoard.displayGuessBoard();
            playerA.shipBoard.displayShipBoard();
            Console.WriteLine();

            // ask player for a guess
            Console.Write(playerA.Name + ", please enter your guess (eg A5): ");
            string guess = Console.ReadLine();

            // check for valid input 
            while (guess.Length < 2 || guess.Length > 3) {
                Console.WriteLine("Error: " + guess + " is not a valid guess");
                Console.Write(playerA.Name + ", please enter your guess (eg A5): ");
                guess = Console.ReadLine();
            }

            // parse user guess input
            int xCoord = ParseLetter(guess[0]);
            int yCoord;
            if (guess.Length == 3) { // if y-coordinate is 2 digits
                yCoord = ParseDoubleDigit(guess[1], guess[2]);
            } else {
                yCoord = ParseNumber(guess[1]);
            }

            // check for invalid coordinates for guess
            // check for valid board guess (board spot is empty or a ship)
            while (yCoord == -1 || xCoord == -1 || !playerA.guessBoard.isValidGuess(xCoord, yCoord)) {
                Console.WriteLine("Error: " + guess + " is not a valid guess");
                Console.Write(playerA.Name + ", please enter your guess (eg A5): ");
                guess = Console.ReadLine();
                
                xCoord = ParseLetter(guess[0]);
                if (guess.Length == 3) {
                    yCoord = ParseDoubleDigit(guess[1], guess[2]);
                } else {
                    yCoord = ParseNumber(guess[1]);
                }
            }

            // check if hit (ship spot)
            if (playerA.guessBoard.isHit(xCoord, yCoord)) {
                // getting ship index
                int ship = playerA.guessBoard.getShip(xCoord, yCoord);

                // increment ship's hit count
                playerA.fleet.updateHitCount(ship);

                if (playerA.fleet.isShipSunk(ship)) {
                    Console.WriteLine("\nSHIP SUNK!");
                } else {
                    Console.WriteLine("\nSHIP HIT!");
                }
                // update player board spot as a hit
                playerA.guessBoard.updateBoard(xCoord, yCoord, 'h');
                playerB.shipBoard.updateBoard(xCoord, yCoord, 'h');

            } else {
                Console.WriteLine("\nMISS!");
                // update player board spot as a miss
                playerA.guessBoard.updateBoard(xCoord, yCoord, 'm');
                playerB.shipBoard.updateBoard(xCoord, yCoord, 'm');
            }

            // switch player turn
            if (playerTurn == 1) {
                return 2;
            } else {
                return 1;
            }
        }

        // returns index for number coordinate
        // returns -1 if invalid index
        public static int ParseNumber(char number) 
        {
            int index = number - '0' - 1;

            if (index < 0 || index > 8)
            {
                return -1;
            } else {
                return index;
            }
        }

        // returns index for double digit number coordinate
        // returns -1 if invalid index
        public static int ParseDoubleDigit(char digit1, char digit2) 
        {
            int tens = digit1 - '0';
            int ones = digit2 - '0';
            int index = 10 * tens + ones - 1;

            if (index != 9) {
                return -1;
            } else {
                return index;
            }
        }

        // returns index for letter coordinate
        // returns -1 if invalid index
        public static int ParseLetter(char letter) 
        {
            int index = letter - '0' - 17;

            if (index < 0 || index > 9) {
                return -1;
            } else {
                return index;
            }
        }
    }
}
