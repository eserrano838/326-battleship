using System;
namespace BattleShip
{
    public class Fleet
    {
        public Ship[] Ships = new Ship[5];

        public Fleet()
        {
            Ships[0] = new Ship("Carrier", 5);
            Ships[0].XLocations = new int[5];
            Ships[0].YLocations = new int[5];

            Ships[1] = new Ship("Battleship", 4);
            Ships[1].XLocations = new int[4];
            Ships[1].YLocations = new int[4];

            Ships[2] = new Ship("Cruiser", 3);
            Ships[2].XLocations = new int[3];
            Ships[2].YLocations = new int[3];

            Ships[3] = new Ship("Submarine", 3);
            Ships[3].XLocations = new int[3];
            Ships[3].YLocations = new int[3];

            Ships[4] = new Ship("Destroyer", 2);
            Ships[4].XLocations = new int[2];
            Ships[4].YLocations = new int[2];
        }

        public void setShipLocation(int ship, int i, int x, int y) {
            Ships[ship].setXLocations(i, x);
            Ships[ship].setYLocations(i, y);
        }
    }
}
