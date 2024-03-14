using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAutal;

        //public Carro() { }

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;

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

        public virtual int Acelerar() {
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

    public class Ferrari : Carro {
        public Ferrari() : base(350) { }

        public override int Acelerar() {
            return AlterarVelocidade(15);

        }
        // o new na declaração da assinatura oculta da classe pai
        public new int Frear() {
            return AlterarVelocidade(-15);
        }

    }

    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();

            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Ferrari carro2 = new Ferrari();

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); //Polimorfismo


            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());


            Console.WriteLine("Unot com tipo Carro...");
            carro3 = new Uno(); //Polimorfismo

            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());



        }
    }
}
