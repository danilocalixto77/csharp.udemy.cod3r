using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Aprensentar() {
            return string.Format($"Meu nome é {Nome} e tenho {Idade}");
        }

        public void AprensentarNoConsole() {
            Console.WriteLine(Aprensentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
