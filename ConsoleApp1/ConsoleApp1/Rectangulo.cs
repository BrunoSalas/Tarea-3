using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangulo: Shape, Area , Perimeter

        
    {
        float b;
        float h;

        public Rectangulo (float b, float h)
        {
            this.b = b; this.h = h;

        }

        public float CalculatePerimeter()
        {
            return 2 * (b + h);
        }

        public float CalculetArea()
        {
            return b * h;
        }
    }
}
