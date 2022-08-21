using System;

namespace Polimorfismo01.src {
    public class Cat : Animal {
        public Cat (string name, string color, int age, Classificacao tipo) : base(name, color, age, tipo) {
        }

        public override void Run() {
            Console.WriteLine("I'm running on the sand!");
        }
        public override void Sleep() {
            Console.WriteLine("I'm sleeping ...zzz...zzz!");
        }
    }
}