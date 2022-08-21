using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Zoo.PolimorGeom.src {
    public class AreaCalculator {
        public double Area { get; set; }
        public double Base { get; set; }
        public double Hight { get; set; }
        //public double Rectangle { get; set; }

        public AreaCalculator(double area, double aBase, double aHight) {
            Area = area;
            Base = aBase;
            Hight = aHight;
        }
    }
}