using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é: " + area + 1000);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendao " + estaChovendo);

            byte idade = 45;

            Console.WriteLine("Idade é: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;

            Console.WriteLine("Saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);

            ulong populaçaoMundial = 7_600_000_000;
            Console.WriteLine("População mundical: " + populaçaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preco do coputador: " + precoComputador);

            double valorDeMercadoDaApple = 100000000000000; // mais utilizado entre os reais
            Console.WriteLine("Valor de mercado da Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas: " + distanciaEntreEstrelas);

            char letra = 'd';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja benvindo ao C#";
            Console.WriteLine(texto);

        }

    }
}
