using System;
namespace BattleShip
{
    public class Ship
    {
        public int Size { get; set; }
        public string Name { get; set; }
        public int[] XLocations;
        public int[] YLocations;
        public int hitCount = 0;
 
        public Ship(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public void setXLocations(int i, int x) {
            XLocations[i] = x;
        }

        public void setYLocations(int i, int y)
        {
            YLocations[i] = y;
        }

        // returns true 
        public Boolean hasSunk() {
            return (hitCount == Size);
        }
    }
}
