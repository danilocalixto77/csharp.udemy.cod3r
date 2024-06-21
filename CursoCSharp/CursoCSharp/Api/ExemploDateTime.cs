using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);


            // Sem horas
            var dataHoje = DateTime.Today;

            Console.WriteLine(dataHoje);

            // Com horas
            var dataHojeComHora = DateTime.Now;

            Console.WriteLine(dataHojeComHora);
            Console.WriteLine("Hora: " + dataHojeComHora.Hour);
            Console.WriteLine("Minutos: " + dataHojeComHora.Minute);

            var amanha = dataHojeComHora.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = dataHojeComHora.AddDays(-1);
            Console.WriteLine(ontem);

            //Formatação de datas:
            Console.WriteLine(dataHojeComHora.ToString("dd"));
            Console.WriteLine(dataHojeComHora.ToString("d"));
            Console.WriteLine(dataHojeComHora.ToString("D"));

            Console.WriteLine(dataHojeComHora.ToString("g"));
            Console.WriteLine(dataHojeComHora.ToString("G"));


            //Formatando especificamente com o formato customizado
            Console.WriteLine(dataHojeComHora.ToString("dd-MM-yyyy HH:mm"));


        }
    }
}
