using System;
using System.Collections.Generic;
using System.Linq;


namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno {Nome = "Pedro", Idade = 24, Nota= 8.0},
                new Aluno {Nome = "Andre", Idade = 21, Nota= 4.3},
                new Aluno {Nome = "Ana", Idade = 25, Nota= 9.5},
                new Aluno {Nome = "Jorge", Idade = 20, Nota= 8.5},
                new Aluno {Nome = "Ana", Idade = 21, Nota= 7.7},
                new Aluno {Nome = "Julia", Idade = 22, Nota= 7.5},
                new Aluno {Nome = "Marcio", Idade = 18, Nota= 6.8}
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine("{0} , {1}", pedro.Nome, pedro.Nota);

            
            
            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));



            if (fulano == null) {
                Console.WriteLine("Aluno Inexistente");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);


            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));

            if (sicrano == null) {
                Console.WriteLine("Aluno não existe");
            }


            var outraAna = alunos.Last(aluno => aluno.Nome.Equals("Ana"));
                Console.WriteLine(outraAna.Nota);

            var outraAna2 = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana2"));

            if (outraAna2 == null) {
                Console.WriteLine("Ana 2 não existe");
            }

            //Função para paginação de estruturas
            //Skip salto 
            //Take registro pegos

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);

            }


            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somaNota = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somaNota);

            var mediaNota = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNota);
            
            var mediaNotaAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotaAprovados);






        }
    }
}
