using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {

        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}{1:D2}{2:D2}", dia, mes, ano);
        }
        public static void Executar() {
            Formatar(mes: 2, dia: 12, ano: 2024);

        }
    }
}
