using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    class Heranca {

        public class Carro {
            protected readonly int VelocidadeMaxima;
            int VelocidadeAutal;

            public Carro() {

            }
            public Carro(int velocidadeMaxima) {
                velocidadeMaxima = velocidadeMaxima;

            }

            protected int AlterarVelocidade(int delta) {
                int novaVelocidade = VelocidadeAutal + delta;

                if (novaVelocidade < 0) {
                    VelocidadeAutal = 0;
                } else if (novaVelocidade > VelocidadeMaxima) {
                    VelocidadeAutal = VelocidadeMaxima;

                } else {
                    VelocidadeAutal = novaVelocidade;
                }
                return VelocidadeAutal;

            }

            public int Acelerar() {
                return AlterarVelocidade(5);
            }

            public int Frear() {
                return AlterarVelocidade(-5);
            }
        }

        public class Uno : Carro {
            //Construtor de Uno chamando o construtor base da classe pai
            public Uno() : base(200) {
            }

        }

        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno car1 = new Uno();

            Console.WriteLine(car1.Acelerar(5));
            Console.WriteLine(car1.Acelerar(5));
            Console.WriteLine(car1.Frear(5));



        }
    }
}
