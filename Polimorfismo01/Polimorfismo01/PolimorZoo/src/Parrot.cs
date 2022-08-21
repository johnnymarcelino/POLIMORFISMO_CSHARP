using System;

namespace Polimorfismo01.src {
    public class Parrot : Animal {
        public Parrot(string name, string color, int age, Classificacao tipo) : base(name, color, age, tipo) {
        }

        public override void Fly() {
            Console.WriteLine("I'm flying in the house of my friend!");
        }
        public override void Peck() {
            Console.WriteLine("I'm pecking this wood!");
        }
    }
}