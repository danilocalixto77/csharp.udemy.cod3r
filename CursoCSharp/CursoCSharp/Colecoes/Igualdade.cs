using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.ClassesEMetodos.AtributosEstaticos;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            //Essa igualdade está comparando referências de memória, por isso retornou false.
            Console.WriteLine(p1 == p2);

            //Essa igualdade está comparando a mesma referências de memória, por isso retornou true.
            Console.WriteLine(p3 == p2);

            //Para comparar objetos usando o equals() também fez a mesma comparação por referências de memória que retornou false.
            Console.WriteLine(p1.Equals(p2));

            //Fazendo o override do Equals para comparar valores teremos o valor dos objetos igual a true.
            Console.WriteLine(p1.Equals(p2));



        }
    }
}
