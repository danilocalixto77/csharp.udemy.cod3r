using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {
    class ExcecoesPersonalizadas {

        public class NegativoException : Exception {
            public NegativoException() { }

            public NegativoException(string message) : base(message) { }

            public NegativoException(string message, Exception inner) : base(message, inner) { }    
        }

        class ExcecoesPersonalizadas {
            public static int PositivoPar() {
                Random random = new Random();
                int valor = random.Next(-30, 30);

                if (valor < 0) {
                    throw new NegativoException("Numero negativo...");
                }

                if (valor % 2 == 1) {
                    throw new ImparException("Valor impar...");
                }
                return valor; 
            }

            public static void Executar() {

            }

        }

        public class ImparException : Exception { 
            public ImparException(string message) : base(message) { }
        
        }
       
    }
}
