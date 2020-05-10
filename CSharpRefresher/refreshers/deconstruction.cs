using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefresher.refreshers
{
    class deconstruction
    {
        public void testDeconstruction()
        {
            (int X, int Y) pointer1 = (2, 3);
            (int X, int Y) pointer2 = (5, 6);

            //deconstruction
            (int x, int y) = pointer1;
            Console.WriteLine($"X:{x}, Y:{y}");

            (x, y) = pointer2;
            Console.WriteLine($"X:{x}, Y:{y}");
        }

    }
}
