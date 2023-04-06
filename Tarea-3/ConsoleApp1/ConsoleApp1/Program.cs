using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
      static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            while (true)
            {
                Console.WriteLine("Escribir el número para añadir figura");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Triángulo");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Introducir el radio del círculo");
                        float radius = float.Parse(Console.ReadLine());
                        shapes.Add(new Circle(radius));
                        break;
                    case "2":
                        Console.WriteLine("Introducir la base del triángulo");
                        float triangleB = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introducir la altura del triángulo");
                        float triangleH = float.Parse(Console.ReadLine());
                        shapes.Add(new Triangle(triangleB, triangleH));
                        break;

                }

                Console.WriteLine("Areas");
                foreach (Shape shape in shapes)
                {
                  //  Console.WriteLine($"{shape.GetName()}: {shape.CalculateArea()}");
                }

            }

            Console.ReadLine();
        }
    }
}
