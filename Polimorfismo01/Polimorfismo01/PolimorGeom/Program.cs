using Polimorfismo_Zoo.PolimorGeom.src;
using System;

namespace Polimorfismo_Zoo.PolimorGeom {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("What is the hight of the square ? ");
            double hight_square = Convert.ToDouble(Console.ReadLine());
            Square square = new Square("Square", hight_square, hight_square);
            Console.WriteLine($"The total area of a square with a hight and base {square.Hight} is: {square.TotalArea()}");
            Console.ReadKey();

            Console.WriteLine("Digite a altura do triângulo: ");
            double hight_triangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a base do triângulo: ");
            double baseTriangle = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle("Triangle", hight_triangle, baseTriangle);
            Console.WriteLine($"A área total de um triângulo com altura {triangle.Hight} e base {triangle.Base} é de {triangle.TotalArea()}");
            Console.ReadKey();

            Console.WriteLine("Digite a altura do retângulo: ");
            double hight_rectangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a base do retângulo: ");
            double baseRectangle = Convert.ToDouble(Console.ReadLine());
            Rectangle retangulo = new Rectangle("Rectangle", baseRectangle, baseRectangle);
            Console.WriteLine($"A área total de um retângulo com altura {retangulo.Hight} e base {retangulo.Base} é de {retangulo.TotalArea()}");
            Console.ReadKey();
        }
    }
}
