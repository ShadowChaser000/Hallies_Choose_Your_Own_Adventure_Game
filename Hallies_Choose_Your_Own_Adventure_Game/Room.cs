using System;

namespace Hallies_Choose_Your_Own_Adventure_Game
{
    internal class Room
    {
        public int north, south, east, west;

        public string name = "Unknown Room";

        public string description = "You are nowhere - how did you even get here?!";


        public Room(int north, int south, int east, int west)
        {
            this.north = north;
            this.south = south;
            this.east = east;
            this.west = west;

        }

        public override string ToString()
        {
            return "\n\n" + name.PadLeft(((Console.WindowWidth - name.Length) - 1) / 2) + "\n\n" + description;
        }
    }
}