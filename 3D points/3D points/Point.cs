using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int _x = 0, int _y = 0, int _z = 0)
        {
            X = _x;
            Y = _y;
            Z = _z;

        }

        public double caldistance(Point v)
        {

            double d = Math.Sqrt(Math.Pow(v.X - this.X, 2) + Math.Pow(v.Y - this.Y, 2) + Math.Pow(v.Z - this.Z, 2));
            return d;
        }
    }
}
