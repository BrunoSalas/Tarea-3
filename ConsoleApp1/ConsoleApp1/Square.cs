using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square : Shape, Area, Perimeter
    {
        float b;

        public Square(float b)
        {
            this.b = b;
        }
        public float CalculatePerimeter()
        {
            return 4 * b;
        }

        public float CalculetArea()
        {
            return b * b; 
        }
    }
}
