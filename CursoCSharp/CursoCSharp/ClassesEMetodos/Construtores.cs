using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;
    }
    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "Renault";
            carro1.Modelo = "Kwid";
            carro1.Ano = 2022;

            Console.WriteLine($"{carro1.Fabricante} - {carro1.Modelo} - {carro1.Ano}");
        }
    }
}
