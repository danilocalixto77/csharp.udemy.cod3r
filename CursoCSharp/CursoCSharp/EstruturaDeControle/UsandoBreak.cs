using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class UsandoBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            for(int i = 0; i <= 51; i++) {
                Console.WriteLine("O numero que queremos é {0}", i);
                if (i == numero) {
                    Console.Write("Encontramos!");
                    break;
                } else {
                    Console.Write("Continua procurando");

                }
            }


        }
    }
}
