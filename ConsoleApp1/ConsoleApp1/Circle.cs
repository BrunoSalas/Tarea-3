using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Shape, Area, Perimeter
    {
        private float radius;

        public Circle(float radius)
        {
            this.name = "Círculo";
            this.radius = radius;
        }

        public float CalculatePerimeter()
        {
            return (2 * 3.14f) * radius;
        }

        public float CalculetArea()
        {
            return radius * radius * 3.14f;
        }
    }
}
