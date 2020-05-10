using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefresher.refreshers
{
    class tuples
    {
        public void buildTuples()
        {
            (int x, int y) tuplePoints = (3, 4);
            Console.WriteLine($"points are located at ({tuplePoints.x},{tuplePoints.y})");

            //tuple using var keyword
            var coordinate = (X: 2, Y: 4);
            Console.WriteLine($"{coordinate.X},{coordinate.Y}");
        }
    }
}
