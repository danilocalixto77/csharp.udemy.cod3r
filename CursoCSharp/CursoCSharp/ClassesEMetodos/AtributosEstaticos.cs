﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class AtributosEstaticos {

        public class Produto {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            public string V1 { get; }
            public double V2 { get; }

            public Produto(string nome, double preco, double desconto) {
                this.Nome = nome;
                this.Preco = preco;
                Desconto = desconto;

            }

            public Produto() {

            }

            public Produto(string v1, double v2) {
                V1 = v1;
                V2 = v2;
            }

            public double CalcularDesconto() {
                return Preco - Preco * Desconto;
            }

        }
        public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 10.5,
                //Desconto = 0.5
            };

            Produto.Desconto = 0.55;

            Console.WriteLine("Preço com desconto {0} desconto de {1} %", produto1.CalcularDesconto(), (Produto.Desconto*100));
            Console.WriteLine("Preço com desconto {0} desconto de {1} %", produto2.CalcularDesconto(), (Produto.Desconto*100));

            Produto.Desconto = 0.155;

            Console.WriteLine("Preço com desconto {0} desconto de {1} %", produto1.CalcularDesconto(), (Produto.Desconto * 100));
            Console.WriteLine("Preço com desconto {0} desconto de {1} %", produto2.CalcularDesconto(), (Produto.Desconto * 100));



        }
    }
}
