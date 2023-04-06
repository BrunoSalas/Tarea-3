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
            Circle circle = new Circle(5);
            Square square = new Square(3);
            Rectangulo rectangulo= new Rectangulo(3, 5);
            Triangle triangle = new Triangle(2, 3);

            Perimeter perimeter1 = circle;
            Perimeter perimeter2 = square;
            Perimeter perimeter3 = rectangulo;
            Perimeter perimeter4 = triangle;

            Area area1 = circle;
            Area area2 = square;
            Area area3 = rectangulo;
            Area area4 = triangle;



            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Ingrese que figura quiere operar");
                Console.WriteLine("1.Círculo");
                Console.WriteLine("2.Cuadrado");
                Console.WriteLine("3.Rectángulo");
                Console.WriteLine("4.Triángulo");

                string número = Console.ReadLine();

                switch (número)
                {
                    case "1":
                        Console.WriteLine("Círculo de radio 5");
                        Console.WriteLine($"Perímetro: {perimeter1.CalculatePerimeter()} y Área: {area1.CalculetArea()} ");
                        break;
                    case "2":
                        Console.WriteLine("Cuadrado de lado 3");
                        Console.WriteLine($"Perímetro: {perimeter2.CalculatePerimeter()} y Área: {area2.CalculetArea()} ");
                        break;
                    case "3":
                        Console.WriteLine("Rectángulo de base 3 y altura 5");
                        Console.WriteLine($"Perímetro: {perimeter3.CalculatePerimeter()} y Área: {area3.CalculetArea()} ");
                        break;
                    case "4":
                        Console.WriteLine("Triángulo equilátero de base 2 y altura 3");
                        Console.WriteLine($"Perímetro: {perimeter4.CalculatePerimeter()} y Área: {area4.CalculetArea()} ");
                        break;
                }
                Console.WriteLine("\n");

                bool pregunta = false;

                while (!pregunta)
                {
                    Console.WriteLine("¿Que quieres hacer?");
                    Console.WriteLine("1. Seleccionar otra figura");
                    Console.WriteLine("2. Salir");

                    string respuesta = Console.ReadLine();

                    switch (respuesta)
                    {
                        case "1":
                            pregunta = true;
                            break; 
                        case "2":
                            pregunta = true;
                            salir = true;
                            break;
                    }

                }

            }
        }
    }
}
