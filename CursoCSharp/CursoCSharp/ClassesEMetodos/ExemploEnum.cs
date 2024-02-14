using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
     class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();

            filmeParaFamilia.Titulo = "Sharknardo 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine($" O filme: {filmeParaFamilia.Titulo} é do genero {filmeParaFamilia.GeneroDoFilme}");



        }
    }
}
