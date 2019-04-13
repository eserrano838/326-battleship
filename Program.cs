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

            Player player1 = new Player(player1name);
            Player player2 = new Player(player2name);
            Console.WriteLine();

            player1.setFleetLocations1();
            player2.setFleetLocations2();

            // (goal: get ship positions from player) for now manually placeships

            while (!hasFinished(player1, player2)) {
                if (playerTurn == 1)
                {
                    // display player 1's board
                    player1.guessBoard.displayGuessBoard();
                    player1.shipBoard.displayShipBoard();
                    // ask player 1 for a guess
                    Console.Write(player1.Name + " , please enter your guess (eg A5): ");
                    string guess = Console.ReadLine();

                    // check if valid guess (board spot is "empty" or ship)
                    while (!player1.guessBoard.isValidGuess(guess))
                    {
                        Console.WriteLine(guess + " is not a valid guess");
                        Console.Write(player1.Name + " , please enter your guess (eg A5): ");
                        guess = Console.ReadLine();
                    }

                    // check if hit (ship spot)
                    if (player1.guessBoard.isHit(guess))
                    {
                        int ship = player1.guessBoard.getShip(guess);
                        player1.fleet.updateHitCount(ship);

                        if (player1.fleet.isShipSunk(ship))
                        {
                            Console.WriteLine("SHIP SUNK");
                        }
                        else
                        {
                            Console.WriteLine("SHIP HIT");
                        }

                        player1.guessBoard.updateBoard(guess, 'h');
                        player2.shipBoard.updateBoard(guess, 'h');
                    }
                    else
                    {
                        player1.guessBoard.updateBoard(guess, 'm');
                        player2.shipBoard.updateBoard(guess, 'm');
                    }
                    playerTurn = 2;
                }
                else
                {
                    // display player 2's board
                    player2.guessBoard.displayGuessBoard();
                    player2.shipBoard.displayShipBoard();
                    // ask player 2 for a guess
                    Console.Write(player2.Name + " , please enter your guess (eg A5): ");
                    string guess = Console.ReadLine();

                    // check if valid guess
                    if (player2.guessBoard.isValidGuess(guess))
                    {

                    }
                    // check if hit
                    //      if hit 
                    //      check if ship sunk
                    // check if player won game
                    // update board

                }
            }
            if (player1.fleet.allSunk()) {
                Console.WriteLine(player1name + "won!!!");
            } else {
                Console.WriteLine(player2name + "won!!!");
            }
        }

        public static Boolean hasFinished(Player p1, Player p2) {
            return (!p1.fleet.allSunk() || !p2.fleet.allSunk());
        }
    }
}
