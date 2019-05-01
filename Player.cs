using System;
namespace BattleShip
{
    public class Player
    {
        public string Name { get; set; }
        public Board shipBoard = new Board();
        public Board guessBoard = new Board();
        public Fleet fleet = new Fleet();

        // setting player 1's ship locations        
        public void SetFleetLocations1() {
            // carrier
            fleet.SetShipLocation(0, 0, 1, 3, shipBoard);
            fleet.SetShipLocation(0, 1, 2, 3, shipBoard);
            fleet.SetShipLocation(0, 2, 3, 3, shipBoard);
            fleet.SetShipLocation(0, 3, 4, 3, shipBoard);
            fleet.SetShipLocation(0, 4, 5, 3, shipBoard);

            fleet.SetShipLocation(0, 0, 0, 0, guessBoard);
            fleet.SetShipLocation(0, 1, 0, 1, guessBoard);
            fleet.SetShipLocation(0, 2, 0, 2, guessBoard);
            fleet.SetShipLocation(0, 3, 0, 3, guessBoard);
            fleet.SetShipLocation(0, 4, 0, 4, guessBoard);

            //battleship
            fleet.SetShipLocation(1, 0, 5, 5, shipBoard);
            fleet.SetShipLocation(1, 1, 5, 6, shipBoard);
            fleet.SetShipLocation(1, 2, 5, 7, shipBoard);
            fleet.SetShipLocation(1, 3, 5, 8, shipBoard);

            fleet.SetShipLocation(1, 0, 6, 3, guessBoard);
            fleet.SetShipLocation(1, 1, 7, 3, guessBoard);
            fleet.SetShipLocation(1, 2, 8, 3, guessBoard);
            fleet.SetShipLocation(1, 3, 9, 3, guessBoard);

            //cruiser
            fleet.SetShipLocation(2, 0, 7, 2, shipBoard);
            fleet.SetShipLocation(2, 1, 7, 3, shipBoard);
            fleet.SetShipLocation(2, 2, 7, 4, shipBoard);

            fleet.SetShipLocation(2, 0, 4, 0, guessBoard);
            fleet.SetShipLocation(2, 1, 5, 0, guessBoard);
            fleet.SetShipLocation(2, 2, 6, 0, guessBoard);

            //submarine
            fleet.SetShipLocation(3, 0, 9, 7, shipBoard);
            fleet.SetShipLocation(3, 1, 9, 8, shipBoard);
            fleet.SetShipLocation(3, 2, 9, 9, shipBoard);

            fleet.SetShipLocation(3, 0, 3, 5, guessBoard);
            fleet.SetShipLocation(3, 1, 3, 6, guessBoard);
            fleet.SetShipLocation(3, 2, 3, 7, guessBoard);

            //destroyer
            fleet.SetShipLocation(4, 0, 1, 7, shipBoard);
            fleet.SetShipLocation(4, 1, 2, 7, shipBoard);

            fleet.SetShipLocation(4, 0, 7, 8, guessBoard);
            fleet.SetShipLocation(4, 1, 8, 8, guessBoard);
        }

        // setting player 2's ship locations        
        public void SetFleetLocations2() {
            // carrier
            fleet.SetShipLocation(0, 0, 0, 0, shipBoard);
            fleet.SetShipLocation(0, 1, 0, 1, shipBoard);
            fleet.SetShipLocation(0, 2, 0, 2, shipBoard);
            fleet.SetShipLocation(0, 3, 0, 3, shipBoard);
            fleet.SetShipLocation(0, 4, 0, 4, shipBoard);

            fleet.SetShipLocation(0, 0, 1, 3, guessBoard);
            fleet.SetShipLocation(0, 1, 2, 3, guessBoard);
            fleet.SetShipLocation(0, 2, 3, 3, guessBoard);
            fleet.SetShipLocation(0, 3, 4, 3, guessBoard);
            fleet.SetShipLocation(0, 4, 5, 3, guessBoard);

            //battleship
            fleet.SetShipLocation(1, 0, 6, 3, shipBoard);
            fleet.SetShipLocation(1, 1, 7, 3, shipBoard);
            fleet.SetShipLocation(1, 2, 8, 3, shipBoard);
            fleet.SetShipLocation(1, 3, 9, 3, shipBoard);

            fleet.SetShipLocation(1, 0, 5, 5, guessBoard);
            fleet.SetShipLocation(1, 1, 5, 6, guessBoard);
            fleet.SetShipLocation(1, 2, 5, 7, guessBoard);
            fleet.SetShipLocation(1, 3, 5, 8, guessBoard);

            //cruiser
            fleet.SetShipLocation(2, 0, 4, 0, shipBoard);
            fleet.SetShipLocation(2, 1, 5, 0, shipBoard);
            fleet.SetShipLocation(2, 2, 6, 0, shipBoard);

            fleet.SetShipLocation(2, 0, 7, 2, guessBoard);
            fleet.SetShipLocation(2, 1, 7, 3, guessBoard);
            fleet.SetShipLocation(2, 2, 7, 4, guessBoard);

            //submarine
            fleet.SetShipLocation(3, 0, 3, 5, shipBoard);
            fleet.SetShipLocation(3, 1, 3, 6, shipBoard);
            fleet.SetShipLocation(3, 2, 3, 7, shipBoard);

            fleet.SetShipLocation(3, 0, 9, 7, guessBoard);
            fleet.SetShipLocation(3, 1, 9, 8, guessBoard);
            fleet.SetShipLocation(3, 2, 9, 9, guessBoard);

            //destroyer
            fleet.SetShipLocation(4, 0, 7, 8, shipBoard);
            fleet.SetShipLocation(4, 1, 8, 8, shipBoard);

            fleet.SetShipLocation(4, 0, 1, 7, guessBoard);
            fleet.SetShipLocation(4, 1, 2, 7, guessBoard);
        }
    }
}
