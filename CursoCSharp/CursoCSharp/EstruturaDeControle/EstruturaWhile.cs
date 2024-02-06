using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;

            Random randon = new Random();

            int numeroSecreto = randon.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira um palpite:");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você acertou com {0} tentativas.", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (numeroSecreto > palpite) {
                    Console.WriteLine("É maior!");
                } else if (numeroSecreto < palpite) {
                    Console.WriteLine("É menor!");
                }
                Console.WriteLine($"Só restam {tentativas} tentativas.");

            }
        }

    }
}

