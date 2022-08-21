using System;

namespace Polimorfismo01.src {
    public class Eagle : Animal {
        public Eagle(string name, string color, int age, Classificacao tipo) : base(name, color, age, tipo) {
        }

        public override void Fly() {
            Console.WriteLine("I'm flying in the ar!");
        }
        public override void Peck() {
            Console.WriteLine("I'm pecking you!");
        }
    }
}