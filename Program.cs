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
            System.IO.StreamReader file = new(@"C:\Users\heber\source\repos\hex_template\input.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine("Students can work on this line now: {0}", line);
            }
            file.Close();
            int NumberBlackTitles = 0;
            Console.WriteLine("{0} tiles are black", NumberBlackTitles);
        }
    }
}