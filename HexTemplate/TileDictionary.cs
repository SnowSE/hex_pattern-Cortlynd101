using System;
using System.Collections.Generic;

namespace hex_template
{
    public class TileDictionary
    {
        public Dictionary<(int, int), bool> Tiles = new Dictionary<(int,int), bool>();
        public void flip((int, int) coordinate)
        {
            bool key = Tiles[coordinate];            

            if (key == false)
            {
                Tiles.Remove(coordinate);
                Tiles.Add(coordinate, true);
            } 
            else
            {
                Tiles.Remove(coordinate);
                Tiles.Add(coordinate, false);
            }
        }

        public int CountsBlackTiles()
        {
            var allValues = Tiles.Values;
            int counter = 0;

            foreach (var value in allValues)
            {
                if (value == true)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
