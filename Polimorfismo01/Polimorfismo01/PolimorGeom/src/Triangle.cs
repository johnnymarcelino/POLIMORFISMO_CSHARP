using System;

namespace Polimorfismo_Zoo.PolimorGeom.src {
    public class Triangle : AreaCalculator {
        public Triangle(double area, double aBase, double aHight) : base(area, aBase, aHight) {
        }
        public double TotalArea() {
            return Area = (Base * Hight) / 2;
        }
    }
}