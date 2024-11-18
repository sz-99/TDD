using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2
{
    internal class Compass
    {
        public Point Point { get; set; }

        public Point Rotate(Point point, Direction direction)
        {
            return Point.South;
        }
    }
}
