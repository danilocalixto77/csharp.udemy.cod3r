using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Estruturaif {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);


            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //Ou declarado diretamente desta forma abaixo:

            //bomComportamento = entrada == "S" || entrada == "s";

            //ou

            bomComportamento = entrada.ToLower() == "s";


            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra");
            }

        }

    }
}
