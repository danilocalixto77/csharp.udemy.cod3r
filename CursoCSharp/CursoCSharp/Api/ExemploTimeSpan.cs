using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api {
    class ExemploTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);

            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Dias: " + intervalo.TotalDays);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine($"Duração: {tempo}");


            //Criando um TimeSpan a partir de uma função statica From...
            //Acrecentando minutos a um intervalo de tempo
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(10)));

            //OBS tanto a Add ou Subtract não modifica o valor original da variável intervalo. Ambos fazem a operação do seu valor original.


            //Exemplo de TimeSpan com o ToString

            Console.WriteLine($"ToString 1: {intervalo.ToString("g")}");
            Console.WriteLine($"ToString 2: {intervalo.ToString("G")}");
            Console.WriteLine($"ToString 3: {intervalo.ToString("c")}");

            //Exemplo com parse de uma string para TimeSpan

            Console.WriteLine("Parse: : " + TimeSpan.Parse("01:02:03").TotalMilliseconds);


        }
    }
}
