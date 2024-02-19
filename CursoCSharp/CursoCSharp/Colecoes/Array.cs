using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];

            alunos[0] = "João";
            alunos[1] = "Maria";
            alunos[2] = "Jose";
            alunos[3] = "Carlos";
            alunos[4] = "Daniel";
            
            foreach (string aluno in alunos) { 
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(double nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };

            string palavra = new string(letras);

            Console.WriteLine(palavra);


        }
    }
}
