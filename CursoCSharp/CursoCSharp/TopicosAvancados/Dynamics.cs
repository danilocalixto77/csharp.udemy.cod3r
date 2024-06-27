using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {
            dynamic meuObjeto = "teste";

            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();

            aluno.nome = "Maria Julia";
            aluno.idade = 35;
            aluno.nota = 8.5;

            Console.WriteLine($"{aluno.nome} - {aluno.idade} - {aluno.nota}");

        }
    }
}
