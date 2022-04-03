using System;

namespace hex_template
{
    public class Movement
    {
        //No code here yet, just the basics of an idea we briefly talked about. 
        public bool ParseLine(string line)
        {
            char[] chars = line.ToCharArray();

            string strE = "e";
            char e = char.Parse(strE);

            string strW = "w";
            char w = char.Parse(strW);

            string strN = "n";
            char n = char.Parse(strN);

            string strS = "s";
            char s = char.Parse(strS);
            
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
                if (chars[i] == e)
                {
                    //Console.WriteLine("this is the character {0} at index {1}", chars[i], i);
                }
                else if (chars[i] == w)
                {
                    //Console.WriteLine("this is the character {0} at index {1}", chars[i], i);
                }
                else if (chars[i] == n)
                {
                    if (chars[i + 1] == e || chars[i + 1] == w)
                    {
                        //Console.WriteLine("this is the character {0} at index {1}", chars[i], i);
                        
                    }
                    else
                    {
                        //Console.WriteLine("1 else false");

                        return false;
                    }
                }
                else if (chars[i] == s)
                {
                    if (chars[i + 1] == e || chars[i + 1] == w)
                    {
                        //Console.WriteLine("this is the character {0} at index {1}", chars[i], i);
                        //i = i + 1;
                    }
                    else
                    {
                        //Console.WriteLine("2 else false");

                        return false;
                    }
                }
                else
                {
                    //Console.WriteLine("end else false");
                    return false;
                }
            }
            //Console.WriteLine("got here");
            return true;
        }
        public (int, int) MoveThroughLine((int, int) coordinate, string line)
        //This method will move a coordinate through a set of instructions in the form of a line,
        //then it will return the final destination of the coordinate.
        {
            char[] chars = line.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {

            }

            return coordinate;
        }
        public void MoveEast((int, int) coordinate)
        //This method change the coordinate so that it has moved east.
        {
            throw new NotImplementedException();
        }
        public void MoveWest((int, int) coordinate)
        //This method change the coordinate so that it has moved west.
        {
            throw new NotImplementedException();
        }
        public void NorthEast((int, int) coordinate)
        //This method change the coordinate so that it has moved northeast.
        {
            throw new NotImplementedException();
        }
        public void NorthWest((int, int) coordinate)
        //This method change the coordinate so that it has moved northwest.
        {
            throw new NotImplementedException();
        }
        public void SouthEast((int, int) coordinate)
        //This method change the coordinate so that it has moved southeast.
        {
            throw new NotImplementedException();
        }
        public void SouthWest((int, int) coordinate)
        //This method change the coordinate so that it has moved southwest.
        {
            throw new NotImplementedException();
        }
    }
}
