using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "trim tim tim...";
        }

    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá meu nome é Bixby!" ;

        }

    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Olá meu nome é Siri";
        }
    }

    class Abstract {
        public static void Executar() {

            var celulares = new List<Celular>{
                new IPhone(),
                new Samsung()

            };

            foreach (var celuar in celulares) {
                Console.WriteLine(celuar.Assistente());
            }



            
        
        }
    }
}
