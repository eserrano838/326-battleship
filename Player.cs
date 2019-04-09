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

        public void setFleetLocations() {
            // ask user for where they want their ships and update ship loactions

            // carrier
            fleet.setShipLocation(0, 0, 1, 3);
            fleet.setShipLocation(0, 1, 2, 3);
            fleet.setShipLocation(0, 2, 3, 3);
            fleet.setShipLocation(0, 3, 4, 3);
            fleet.setShipLocation(0, 4, 5, 3);

            //battleship
            fleet.setShipLocation(1, 0, 5, 5);
            fleet.setShipLocation(1, 1, 5, 6);
            fleet.setShipLocation(1, 2, 5, 7);
            fleet.setShipLocation(1, 3, 5, 8);

            //cruiser
            fleet.setShipLocation(2, 0, 7, 2);
            fleet.setShipLocation(2, 1, 7, 3);
            fleet.setShipLocation(2, 2, 7, 4);

            //submarine
            fleet.setShipLocation(3, 0, 9, 7);
            fleet.setShipLocation(3, 1, 9, 8);
            fleet.setShipLocation(3, 2, 9, 9);

            //destroyer
            fleet.setShipLocation(4, 0, 1, 7);
            fleet.setShipLocation(4, 1, 2, 7);
        }
    }
}
