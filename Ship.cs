using System;
namespace BattleShip
{
    public class Ship
    {
        public int Size { get; set; }
        public string Name { get; set; }
        public int[] XCoords { get; set; }
        public int[] YCoords { get; set; }
        public int HitCount { get; set; } = 0;

        // sets ships x location at index i
        public void setXLocations(int i, int x) {
            XCoords[i] = x;
        }

        // sets ships y location at index i
        public void setYLocations(int i, int y)
        {
            YCoords[i] = y;
        }

        // returns true if a ship has sunk
        public Boolean hasSunk() {
            return (HitCount == Size);
        }
    }
}
