using System;
namespace BattleShip
{
    public class Player
    {
        public string Name { get; set; }
        public Board shipBoard = new Board();
        public Board guessBoard = new Board();
        public Fleet fleet = new Fleet();

        public Player(string name)
        {
            Name = name;
        }

        // set player 1 board
        public void setFleetLocations1() {
            // future: ask user for where they want their ships and update ship loactions

            // manually setting ship locations for testing

            // carrier
            fleet.setShipLocation(0, 0, 1, 3, shipBoard);
            fleet.setShipLocation(0, 1, 2, 3, shipBoard);
            fleet.setShipLocation(0, 2, 3, 3, shipBoard);
            fleet.setShipLocation(0, 3, 4, 3, shipBoard);
            fleet.setShipLocation(0, 4, 5, 3, shipBoard);

            //battleship
            fleet.setShipLocation(1, 0, 5, 5, shipBoard);
            fleet.setShipLocation(1, 1, 5, 6, shipBoard);
            fleet.setShipLocation(1, 2, 5, 7, shipBoard);
            fleet.setShipLocation(1, 3, 5, 8, shipBoard);

            //cruiser
            fleet.setShipLocation(2, 0, 7, 2, shipBoard);
            fleet.setShipLocation(2, 1, 7, 3, shipBoard);
            fleet.setShipLocation(2, 2, 7, 4, shipBoard);

            //submarine
            fleet.setShipLocation(3, 0, 9, 7, shipBoard);
            fleet.setShipLocation(3, 1, 9, 8, shipBoard);
            fleet.setShipLocation(3, 2, 9, 9, shipBoard);

            //destroyer
            fleet.setShipLocation(4, 0, 1, 7, shipBoard);
            fleet.setShipLocation(4, 1, 2, 7, shipBoard);
        }

        // set player 2 board
        public void setFleetLocations2()
        {
            // future: ask user for where they want their ships and update ship loactions
           
            // manually setting ship locations for testing

            // carrier
            fleet.setShipLocation(0, 0, 0, 0, shipBoard);
            fleet.setShipLocation(0, 1, 0, 1, shipBoard);
            fleet.setShipLocation(0, 2, 0, 2, shipBoard);
            fleet.setShipLocation(0, 3, 0, 3, shipBoard);
            fleet.setShipLocation(0, 4, 0, 4, shipBoard);

            //battleship
            fleet.setShipLocation(1, 0, 6, 3, shipBoard);
            fleet.setShipLocation(1, 1, 7, 3, shipBoard);
            fleet.setShipLocation(1, 2, 8, 3, shipBoard);
            fleet.setShipLocation(1, 3, 9, 3, shipBoard);

            //cruiser
            fleet.setShipLocation(2, 0, 4, 0, shipBoard);
            fleet.setShipLocation(2, 1, 5, 0, shipBoard);
            fleet.setShipLocation(2, 2, 6, 0, shipBoard);

            //submarine
            fleet.setShipLocation(3, 0, 3, 5, shipBoard);
            fleet.setShipLocation(3, 1, 3, 6, shipBoard);
            fleet.setShipLocation(3, 2, 3, 7, shipBoard);

            //destroyer
            fleet.setShipLocation(4, 0, 7, 8, shipBoard);
            fleet.setShipLocation(4, 1, 8, 8, shipBoard);
        }
    }
}
