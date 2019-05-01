using System;
namespace BattleShip
{
    public class Fleet
    {
        public Ship[] Ships = new Ship[5];

        public Fleet()
        {
            Ships[0] = new Ship { Name = "Carrier", Size = 5 , XCoords = new int[5], YCoords = new int[5] };
            Ships[1] = new Ship { Name = "Battleship", Size = 4 , XCoords = new int[4], YCoords = new int[4] };
            Ships[2] = new Ship { Name = "Cruiser", Size = 3 , XCoords = new int[3], YCoords = new int[3] };
            Ships[3] = new Ship { Name = "Submarine", Size = 3 , XCoords = new int[3], YCoords = new int[3] };
            Ships[4] = new Ship { Name = "Destroyer", Size = 2 , XCoords = new int[2], YCoords = new int[2] };
        }

        // sets ship index i's x and y coordinate location on board for a certain ship
        public void SetShipLocation(int ship, int i, int x, int y, Board board)
        {
            Ships[ship].setXLocations(i, x);
            Ships[ship].setYLocations(i, y);

            if (Ships[ship].Name == "Carrier") {
                board.updateBoard(x, y, 'c');
            } else if (Ships[ship].Name == "Battleship") {
                board.updateBoard(x, y, 'b');
            } else if (Ships[ship].Name == "Cruiser") {
                board.updateBoard(x, y, 'r');
            } else if (Ships[ship].Name == "Submarine") {
                board.updateBoard(x, y, 's');
            } else {
                board.updateBoard(x, y, 'd');
            }
        }

        // returns true if all ships in fleet have been sunk
        public Boolean allSunk() {
            foreach (Ship s in Ships) {
                if (!s.hasSunk()) {
                    return false;
                }
            }
            return true;
        }

        // returns true if a ship is sunk
        public Boolean isShipSunk(int ship) {
            return Ships[ship].hasSunk();
        }

        // increments a ship's hit count
        public void updateHitCount(int ship) {
            Ships[ship].HitCount++;
        }

        // returns total number of hits on ship fleet
        public int TotalHits() {
            int total = 0;
            foreach (Ship s in Ships) {
                total += s.HitCount;
            }
            return total;
        }
    }
}