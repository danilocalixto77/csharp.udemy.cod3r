using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() {

        }


    }

    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Modelo = "Kwid";
            carro1.Fabricante = "Renault";
            carro1.Ano = 2022;

            Console.WriteLine($"{carro1.Modelo} - {carro1.Fabricante} - {carro1.Ano}");


            var carro2 = new Carro("Gol", "VW", 2015);
            Console.WriteLine($"{carro2.Modelo} - {carro2.Fabricante} - {carro2.Ano}");

            var carro3 = new Carro() {
                Modelo = "Fiat 147",
                Fabricante = "Fiat",
                Ano = 2000
            };
            Console.WriteLine($"{carro3.Modelo} - {carro3.Fabricante} - {carro3.Ano}");



        }


    }


}
