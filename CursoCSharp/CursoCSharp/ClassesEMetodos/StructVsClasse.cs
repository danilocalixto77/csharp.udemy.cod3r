using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
        
    }
    class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiadoPonto1 = ponto1;
            ponto1.X = 5; //ATRIBUIÇÃO POR VALOR

            Console.WriteLine("Ponto 1 de X = {0}", ponto1.X);
            Console.WriteLine("Copia do ponto 1 de X {0}", copiadoPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiadoPonto2 = ponto2; //ATRIBUIÇÃO POR REFERENCIA

            Console.WriteLine("Ponto 2 de X = {0}", ponto2.X);
            Console.WriteLine("Copia do ponto 2 de X {0}", copiadoPonto2.X);






        }
    }
}
