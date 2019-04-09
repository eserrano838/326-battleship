using System;

namespace BattleShip
{
    public class Project
    {
        public static void Main(String[] args)
        {
            Boolean isFinished = true;
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

            player1.guessBoard.displayGuessBoard();
            player1.shipBoard.displayShipBoard();
            player2.guessBoard.displayGuessBoard();
            player2.shipBoard.displayShipBoard();

            // (goal: get ship positions from player) for now manually placeships

            /*
            while (!isFinished) {
                if (playerTurn == 1)
                {
                    // display player 1's board
                    // ask player 1 for a guess
                    // check if valid guess
                    // check if hit
                    //      if hit 
                    //      check if ship sunk
                    // check if player won game
                    // update board
                    // switch player player turn
                }
                else
                {
                    // display player 2's board
                    // ask player 2 for a guess
                    // check if valid guess
                    // check if hit
                    //      if hit 
                    //      check if ship sunk
                    // check if player won game
                    // update board
                    // switch player player turn
                }
            }
            */
        }
    }
}
