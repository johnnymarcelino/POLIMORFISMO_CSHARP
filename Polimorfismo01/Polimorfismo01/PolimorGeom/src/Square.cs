using System;

namespace Polimorfismo_Zoo.PolimorGeom.src {
    public class Square : AreaCalculator {
        public Square(double area, double aBase, double aHight) : base(area, aBase, aHight) {
        }
        public double TotalArea() {
            return Area = Base * Hight;
        }
    }
}