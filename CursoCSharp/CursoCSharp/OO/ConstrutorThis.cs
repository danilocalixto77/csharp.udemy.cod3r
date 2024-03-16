using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Animal {
        public string Name { get; set; }

        public Animal(string name) {
            Name = name;

        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) { }   




    }
    class ConstrutorThis {
    public static void Executar() {

    }
}
}
