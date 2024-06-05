using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {
        //Todos -> public
        public string InfoPublica = "Tenho um instagram!";

        //Por herança - protected
        protected string CorDoOlho = "Verde";

        //Mesmo projeto(internal) (assembly)
        internal ulong NumeroCelular = 551199998888;

        //Por herança(protected) ou no mesmo projeto(internal)
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma classe(private) ou herança(protected) mas somente no mesmo projeto (C# 7.2 ou superior)
        private protected string SegredoFamilia = "Bla Bla";

        //Valor padrão(private) visivel dentro da propria classe caso não seja declarado será private
        bool UsaMuitoPhotoShop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoShop);



        }

    }
}
