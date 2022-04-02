using System;

namespace hex_template
{
    public class Movement
    {
        //No code here yet, just the basics of an idea we briefly talked about. 
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