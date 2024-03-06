using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  
        public interface IShape
        {
            double CalculateArea();
        }

        public class Circle : IShape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public double CalculateArea()
            {
                return Width * Height;
            }
        }

        public class Program
        {
            public static void PrintArea(IShape shape)
            {
                Console.WriteLine($"Area: {shape.CalculateArea()}");
            }

            public static void Main(string[] args)
            {
                Circle circle = new Circle(5);
                Rectangle rectangle = new Rectangle(4, 6);

                PrintArea(circle); // Вывод: Area: 78.53981633974483
                PrintArea(rectangle); // Вывод: Area: 24
            Console.ReadLine();
            }
        }

    }