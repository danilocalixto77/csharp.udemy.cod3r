using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    /// <summary>
    /// Digitando 3 barras o .Net invoca o XML comments entre tags
    /// </summary>
    public class Comentarios {
        public static void Executar() {
            //cuidado com comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            /*
            Centários de múltiplas linhas ou por convenção colocar 
            asteriscos no início como boa prática.
            */

            /*
            * Desta forma é uma melhor pratica para comentários.
            * Colocando asteristo em cada linha.
            */

            Console.WriteLine("O C# tem o XML comments!");

            //CTRL + K + C -> COMENTA
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //CTRL + K + U -> COMENTA

        }
    }
}
