using System;

namespace hex_template
{
    public class MovementMethods
    {
        public static bool canParseLine(string line)
        //This method returns a bool representing wether or not the line can be parsed.
        {
            char[] chars = line.ToCharArray();
            
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'e':
                        break;

                    case 'w':
                        break;

                    case 'n':
                        if (chars[i + 1] == 'e' || chars[i + 1] == 'w')
                        {
                            break;
                        }
                        else
                        {
                            return false;
                        }

                    case 's':
                        if (chars[i + 1] == 'e' || chars[i + 1] == 'w')
                        {
                            break;
                        }
                        else
                        {
                            return false;
                        }

                    default:
                        return false;
                }
            }
            return true;
        }
        public static (int, int) moveThroughLine((int, int) coordinate, string line)
        //This method will move a coordinate through a set of instructions in the form of a line,
        //then it will return the final destination of the coordinate.
        {
            char[] chars = line.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'e':
                        coordinate = moveEast(coordinate);
                        break;

                    case 'w':
                        coordinate = moveWest(coordinate);
                        break;

                    case 'n':
                        if (chars[i + 1] == 'e')
                        {
                            coordinate = moveNorthEast(coordinate);
                            i++;
                        }
                        else
                        {
                            coordinate = moveNorthWest(coordinate);
                            i++;
                        }
                        break;

                    case 's':
                        if (chars[i + 1] == 'e')
                        {
                            coordinate = moveSouthEast(coordinate);
                            i++;
                        }
                        else
                        {
                            coordinate = moveSouthWest(coordinate);
                            i++;
                        }
                        break;

                    default:
                        break;
                }
            }
            return coordinate;
        }
        public static (int, int) moveEast((int, int) coordinate)
        //This method change the coordinate so that it has moved east.
        {
            coordinate = (coordinate.Item1 + 2, coordinate.Item2);
            return coordinate;
        }
        public static (int, int) moveWest((int, int) coordinate)
        //This method change the coordinate so that it has moved west.
        {
            coordinate = (coordinate.Item1 - 2, coordinate.Item2);
            return coordinate;
        }
        public static (int, int) moveNorthEast((int, int) coordinate)
        //This method change the coordinate so that it has moved northeast.
        {
            coordinate = (coordinate.Item1 + 1, coordinate.Item2 + 1);
            return coordinate;
        }
        public static (int, int) moveNorthWest((int, int) coordinate)
        //This method change the coordinate so that it has moved northwest.
        {
            coordinate = (coordinate.Item1 - 1, coordinate.Item2 + 1);
            return coordinate;
        }
        public static (int, int) moveSouthEast((int, int) coordinate)
        //This method change the coordinate so that it has moved southeast.
        {
            coordinate = (coordinate.Item1 + 1, coordinate.Item2 - 1);
            return coordinate;
        }
        public static (int, int) moveSouthWest((int, int) coordinate)
        //This method change the coordinate so that it has moved southwest.
        {
            coordinate = (coordinate.Item1 - 1, coordinate.Item2 - 1);
            return coordinate;
        }
    }
}
