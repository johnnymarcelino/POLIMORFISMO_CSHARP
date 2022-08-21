using Polimorfismo_Zoo.PolimorGeom.src;
using System;

namespace Polimorfismo_Zoo.PolimorGeom {
    public class Program {
        static void With(string[] args) {
            Console.WriteLine("What is the hight of the square: ");
            double hight_square = Convert.ToDouble(Console.ReadLine());
            Square square = new Square(4, hight_square, hight_square);
            Console.WriteLine($"The total area of a square with a hight and base {square.Hight} is: {square.TotalArea()}");

            Console.WriteLine("Type the hight of the triangle: ");
            double hight_triangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the triangle base: ");
            double baseTriangle = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle(3, hight_triangle, baseTriangle);
            Console.WriteLine($"The total area of a triangle with a hight {triangle.Hight} and base {triangle.Base} is: {triangle.TotalArea()}");

            Console.WriteLine("Type the hight of the rectangle: ");
            double hight_rectangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the rectagle base: ");
            double baseRectangle = Convert.ToDouble(Console.ReadLine());
            Rectangle retangulo = new Rectangle(4, baseRectangle, baseRectangle);
            Console.WriteLine($"The total area of a rectangle with a hight {retangulo.Hight} and base {retangulo.Base} is: {retangulo.TotalArea()}");
        }
    }
}