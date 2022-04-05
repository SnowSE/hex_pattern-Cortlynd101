using System;
using System.Collections.Generic;

namespace hex_template
{
    public class TileDictionary
    {
        public Dictionary<(int, int), bool> Tiles = new Dictionary<(int,int), bool>();
        public void flipTile((int, int) coordinate)
        //This method flips a tile from black to white and vice versa.
        //In this case black is true and white is false.
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

        public int countsBlackTiles()
        //This method counts the amount of true bools in a dictionary. 
        //This representing the black tiles.
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

        public static void handleFinalDestination(TileDictionary tileDictionary, (int, int) finalPosition, string line)
        //This method gets the finalPostition of a line, tells the user where that position was, and handles it appropriately.
        //If there is no tile with that final position in the dictionary it makes one, but if it exists it flips it.
        //Will only move through parseable lines.
        {
            if (MovementMethods.canParseLine(line) == true)
            {
                finalPosition = MovementMethods.moveThroughLine(finalPosition, line);
                Console.WriteLine($"Final Postion is {finalPosition}");

                if (tileDictionary.Tiles.ContainsKey(finalPosition) == false)
                {
                    tileDictionary.Tiles.Add(finalPosition, true);
                }
                else
                {
                    tileDictionary.flipTile(finalPosition);
                }

            }
            else
            {
                Console.WriteLine($"This line can not be parsed. Line {0}", line);
            }

            finalPosition = (0, 0);
        }
    }
}
