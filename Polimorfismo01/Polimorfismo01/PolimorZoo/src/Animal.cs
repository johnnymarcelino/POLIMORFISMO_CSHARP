using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo01.src {
    public class Animal {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public Classificacao Tipo { get; set; }

        public Animal(string name, string color, int age, Classificacao tipo) {
            Name = name;
            Age = age;
            Color = color;
            Tipo = tipo;
        }
        public virtual void Run() {
            Console.WriteLine($"{Name} it is running now");
        }
        public virtual void Sleep() {
            Console.WriteLine($"{Name} it is eating now");
        }
        public virtual void Fly() {
            Console.WriteLine($"{Name} eating now");
        }
        public virtual void Peck() {
            Console.WriteLine($"{Name} eating now");
        }

        public enum Classificacao {
            Terrestre,
            Aereo
        }
    }
}
