using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 2, 3);
            Point p2 = new Point(1, 2, 1);

            Console.Write(p1.caldistance(p2));
            Console.Read();
        }
    }
}
