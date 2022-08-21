using System;

namespace Polimorfismo_Zoo.PolimorGeom.src {
    public class Rectangle : AreaCalculator {
        public Rectangle(double area, double aBase, double aHight) : base(area, aBase, aHight) {
        }
        public double TotalArea() {
            return Area = Base * Hight;
        }
    }
}