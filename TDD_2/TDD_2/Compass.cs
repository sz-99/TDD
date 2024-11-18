using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2
{
    public class Compass
    {
        public Point point { get; set; }

        public Point Rotate(Point point, Direction direction)
        {
            if (direction == Direction.right)
            {
                if (point == (Point)3)
                {
                    point = Point.North;
                }
                else
                {
                    point += 1;
                }
            }
            else if (direction == Direction.left)
            {
                if (point == (Point)0)
                {
                    point = Point.West;
                }
                else
                {
                    point -= 1;
                }
            }
            return point;
           
        }
    }
}
