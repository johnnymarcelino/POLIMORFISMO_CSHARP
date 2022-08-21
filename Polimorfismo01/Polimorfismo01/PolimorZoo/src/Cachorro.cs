using System;

namespace Polimorfismo01.src {
    public class Cachorro : Animal {
        public Cachorro(string name, string color, int age, Classificacao tipo) : base(name, color, age, tipo) {
        }

        public override void Run() {
            Console.WriteLine("I'm running on the hold!");
        }
        public override void Sleep() {
            Console.WriteLine("I'm sleeping at my house ...zzz...zzz!");
        }
    }
}