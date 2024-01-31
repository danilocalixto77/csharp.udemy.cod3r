using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            //Converte implicitamente
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Converter Explicitamente para funcionar
            double nota = 9.7;
            int notaTruncada = (int) nota; //Esta conversão é conhecida como cast
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}"+ idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Idade inserida: {0}" + idadeInteiro);

            Console.Write("Digite o primeiro número:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado 1 {0}", numero);

            Console.Write("Digite o segundo número:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 1 {0}", numero);


        }
    }
}
