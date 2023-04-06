using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    abstract class Shape
    {
        protected string name;

        public string GetName()
        {
            return name;
        }

        public abstract float CalculateArea();
    }
}
