using Polimorfismo01.src;
using System;

namespace Polimorfismo_Zoo.PolimorZoo {
    class Program {
        static void Main(string[] args) {
            var sanara = new Eagle("sanara", "white", 2, Animal.Classificacao.Aereo);
            var tagalot = new Parrot("tagalot", "green", 13, Animal.Classificacao.Aereo);
            var gotz = new Cat("sanara", "orange", 8, Animal.Classificacao.Terrestre);
            var brockillow = new Cachorro("sanara", "brown", 6, Animal.Classificacao.Terrestre);
        }
    }
}
