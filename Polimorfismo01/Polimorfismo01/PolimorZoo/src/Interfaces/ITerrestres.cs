using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo01.src.Interfaces {
    public interface ITerrestres {
        void Run() {
            Console.WriteLine("I can running!");
        }
        void Sleep() {
            Console.WriteLine("I can sleep!");
        }
    }
}
