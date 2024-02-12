using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;   
        }

        public int Multplicar(int a, int b) {
            return a * b;   
        }
    }

    class CalculadoraCadeia {
        int memoria;
        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;    
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;

        }

    }

    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);

            Console.WriteLine(calculadoraComum.Subtrair(7,2));

            Console.WriteLine(calculadoraComum.Multplicar(4, 4));

            var calculadoraCadeira = new CalculadoraCadeia();

            calculadoraCadeira.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeira.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);

        }

    }
}
