using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    class Nullables {
        public static void Executar() {

            //Utilizando o proprio generci do Nullable
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue) {
                Console.WriteLine($"Valor de num: {num1}");
            } else {
                Console.WriteLine("A variável não possui valor");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(num1);

            bool? boleana = null;
            bool resultado = boleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y );
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
