using System;

namespace hex_template
{
    public class Movement
    {
        public static bool ParseLine(string line)
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
        public static (int, int) MoveThroughLine((int, int) coordinate, string line)
        //This method will move a coordinate through a set of instructions in the form of a line,
        //then it will return the final destination of the coordinate.
        {
            char[] chars = line.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'e':
                        coordinate = MoveEast(coordinate);
                        break;

                    case 'w':
                        coordinate = MoveWest(coordinate);
                        break;

                    case 'n':
                        if (chars[i + 1] == 'e')
                        {
                            coordinate = MoveNorthEast(coordinate);
                            i++;
                        }
                        else
                        {
                            coordinate = MoveNorthWest(coordinate);
                            i++;
                        }
                        break;

                    case 's':
                        if (chars[i + 1] == 'e')
                        {
                            coordinate = MoveSouthEast(coordinate);
                            i++;
                        }
                        else
                        {
                            coordinate = MoveSouthWest(coordinate);
                            i++;
                        }
                        break;

                    default:
                        break;
                }
            }
            return coordinate;
        }
        public static (int, int) MoveEast((int, int) coordinate)
        //This method change the coordinate so that it has moved east.
        {
            coordinate = (coordinate.Item1 + 2, coordinate.Item2);
            return coordinate;
        }
        public static (int, int) MoveWest((int, int) coordinate)
        //This method change the coordinate so that it has moved west.
        {
            coordinate = (coordinate.Item1 - 2, coordinate.Item2);
            return coordinate;
        }
        public static (int, int) MoveNorthEast((int, int) coordinate)
        //This method change the coordinate so that it has moved northeast.
        {
            coordinate = (coordinate.Item1 + 1, coordinate.Item2 + 1);
            return coordinate;
        }
        public static (int, int) MoveNorthWest((int, int) coordinate)
        //This method change the coordinate so that it has moved northwest.
        {
            coordinate = (coordinate.Item1 - 1, coordinate.Item2 + 1);
            return coordinate;
        }
        public static (int, int) MoveSouthEast((int, int) coordinate)
        //This method change the coordinate so that it has moved southeast.
        {
            coordinate = (coordinate.Item1 + 1, coordinate.Item2 - 1);
            return coordinate;
        }
        public static (int, int) MoveSouthWest((int, int) coordinate)
        //This method change the coordinate so that it has moved southwest.
        {
            coordinate = (coordinate.Item1 - 1, coordinate.Item2 - 1);
            return coordinate;
        }
    }
}
