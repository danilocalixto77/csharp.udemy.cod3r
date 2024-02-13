using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, int cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);  
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;  
        }


        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada) {
            //1º Opção de validação
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //} else
            //    Cilindrada = 0;

            //2º Opção de validação
            //Cilindrada = Math.Abs(cilindrada);

            //3º Opção de validação para valor negativo modificar o tipo da variável de int para uint
        }

    }

    class GetSet {
        public static void Executar() {

            var moto1 = new Moto("Honda", "CG", -150);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());


            var moto2 = new Moto();
            moto2.SetMarca("Suzuki");
            moto2.SetModelo("SYXPZ");
            moto2.SetCilindrada(-200);

            Console.WriteLine("Moto da Marca: "+moto2.GetMarca()+" do Modelo: "+moto2.GetModelo()+" "+moto2.GetCilindrada()+" Cilindradas");

        }
    }
}
