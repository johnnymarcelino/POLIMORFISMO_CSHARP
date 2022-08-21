using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo01.src.Interfaces {
    public interface IAereos {
        void Fly() {
            Console.WriteLine("I can fly!");
        }
        void Peck() {
            Console.WriteLine("I can peck!");
        }
    }
}
