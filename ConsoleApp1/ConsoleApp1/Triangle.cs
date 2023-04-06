using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : Shape, Area
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            this.name = "Triángulo";
            this.b = b;
            this.h = h;
        }

        public float CalculetArea()
        {
            return b * h / 2;
        }
    }
}
