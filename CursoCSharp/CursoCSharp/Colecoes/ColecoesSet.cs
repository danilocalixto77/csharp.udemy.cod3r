using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesSet {

        class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa tema�tica", 29.9),
                new Produto("Oitava Temporada de GoT",99.9),
                new Produto("Poster", 15)
            };

            //M�todo para adicionar um range de v�rios valores de uma List

            carrinho.UnionWith(combo);


            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);
            carrinho.Add(livro);

            foreach(var item in carrinho) {
                //Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);




        }
    }
}