using System;
using System.Collections.Generic;
using System.Text;

namespace WordGuess.Business
{
    public class Point
    {
        public int currentPoint = 0;
        public Point()
        {

        }

        public void AddPoint()
        {
            currentPoint++;
        }

        public int GetPoints()
        {
            return currentPoint;
        }
    }
}
