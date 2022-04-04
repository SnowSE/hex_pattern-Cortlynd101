using System;

namespace hex_template
{
    class Program
    {
        /// <summary>
        ///  tiles take up 2 spaces
        ///  origin tile is (0,0) (and covers 0,0 and 0,1)
        ///          east tile is (2,0)
        ///          west tile is (-2,0)
        ///          ne tile is (1,1)
        ///          nw tile is (-1,1)
        ///          se tile is (1,-1)
        ///          sw tile is (-1,-1)
        ///      line  1 xxxxxxxccbbxxxxxxx
        ///      line  0 xxxxxxddaaeexxxxxx
        ///      line -1 xxxxxxxffggxxxxxxx
        /// </summary>
        static void Main(string[] args)
        {
            string line;
            System.IO.StreamReader file = new(@"C:\Users\Cortl\Source\Repos\hex_pattern-Cortlynd101\HexTemplate\sample.txt"); //This will need to be changed for your individual machine!!!

            (int, int) finalPosition = (0, 0);
            TileDictionary tileDictionary = new TileDictionary();

            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine("Students can work on this line now: {0}", line);
                if (Movement.ParseLine(line))
                {
                    finalPosition = Movement.MoveThroughLine(finalPosition, line);
                    Console.WriteLine($"Final Postion is {finalPosition}");

                    if (tileDictionary.Tiles.ContainsKey(finalPosition) == false)
                    {
                        tileDictionary.Tiles.Add(finalPosition, true);
                    }
                    else
                    {
                        tileDictionary.flip(finalPosition);
                    }
                    
                }
                else
                {
                    Console.WriteLine($"This line can not be parsed. ");
                }
                
                finalPosition = (0, 0);
            }

            int blackTiles = tileDictionary.CountsBlackTiles();
            Console.WriteLine($"Total number of black tiles: {blackTiles}");

            file.Close();
            int NumberBlackTitles = 0;
            Console.WriteLine("{0} tiles are black", NumberBlackTitles);
        }
    }
}