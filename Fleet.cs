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

        public void setShipLocation(int ship, int i, int x, int y, Board board)
        {
            Ships[ship].setXLocations(i, x);
            Ships[ship].setYLocations(i, y);
            if (Ships[ship].Name == "Carrier")
            {
                board.updateBoard(x, y, 'c');
            }
            else if (Ships[ship].Name == "Battleship")
            {
                board.updateBoard(x, y, 'b');
            }
            else if (Ships[ship].Name == "Cruiser")
            {
                board.updateBoard(x, y, 'r');
            }
            else if (Ships[ship].Name == "Submarine")
            {
                board.updateBoard(x, y, 's');
            }
            else
            {
                board.updateBoard(x, y, 'd');
            }
        }

        // returns true if all ships in fleet have been sunk
        public Boolean allSunk() {
            for (int i = 0; i < 5; i ++) {
                if (!Ships[i].hasSunk()) {
                    return false;
                }
            }
            return true;
        }

        public Boolean isShipSunk(int ship) {
            return Ships[ship].hasSunk();
        }

        // increments a ships hit count
        public void updateHitCount(int ship) {
            Ships[ship].hitCount++;
        }
    }
}