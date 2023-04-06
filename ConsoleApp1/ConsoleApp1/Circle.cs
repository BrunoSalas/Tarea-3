using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Shape, Area
    {
        private float radius;

        public Circle(float radius)
        {
            this.name = "Círculo";
            this.radius = radius;
        }

        public override float CalculateArea()
        {
            return radius * radius * 3.14f;
        }
    }
}
