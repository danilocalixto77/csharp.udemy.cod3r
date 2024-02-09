using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Pedro";
            sicrano.Idade = 35;

            //Console.WriteLine($"Meu nome é {sicrano.Nome} e tenho {sicrano.Idade}");

            sicrano.AprensentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Luis";
            fulano.Idade = 33;

            var apresentarFulano = fulano.Aprensentar();
            Console.WriteLine(apresentarFulano.Length);
            Console.WriteLine(apresentarFulano);



        }
    }
}
