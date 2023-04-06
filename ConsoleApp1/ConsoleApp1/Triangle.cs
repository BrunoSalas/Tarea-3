using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : Shape, Area, Perimeter
    {
        float b;
        float h;

        public Triangle(float b, float h)
        {
            this.name = "Triángulo";
            this.b = b;
            this.h = h;
        }

        public float CalculatePerimeter()
        {
            return b * 3; 
        }

        public float CalculetArea()
        {
            return b * h / 2;
        }
    }
}
