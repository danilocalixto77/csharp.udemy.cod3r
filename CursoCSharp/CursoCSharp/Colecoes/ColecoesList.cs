using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesList {

        class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }


            public override bool Equals(object obj) {
                Produto outroProduto = (Produto)obj;
                bool mesmoNome = Nome == outroProduto.Nome;
                bool mesmoPreco = Preco == outroProduto.Preco;
                return mesmoNome && mesmoPreco;
            }

            public override int GetHashCode() {
                return Nome.Length;
            }

        }



        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa temaática", 29.9),
                new Produto("Oitava Temporada de GoT",99.9),
                new Produto("Poster", 15)
            };

            //Método para adicionar um range de vários valores de uma List

            carrinho.AddRange(combo);


            Console.WriteLine(carrinho.Count);

            carrinho.RemoveAt(3);

            foreach(var item in carrinho) {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }



        }
    }
}