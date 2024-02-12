using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraEstatica {
        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar (int a, int b) {
            return a * b;   
        }
    }
    class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"O valor da multiplicação é: {resultado}");

            Console.WriteLine("O valor da soma é: {0} ", CalculadoraEstatica.Somar(5,3));

        }
    }
}
