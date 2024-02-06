using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaForEach {
        public static void Executar (){
            var palavra = "Danilo";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new String[] { "Daniel", "Lucia", "Lucca" };

            foreach(var nomes in alunos) {
                Console.WriteLine(nomes);
            }

        }
    }
}
