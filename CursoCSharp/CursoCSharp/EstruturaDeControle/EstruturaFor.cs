﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaFor {
        public static void Executar() {

            //for (int i = 0; i <= 10; i++) {
            //    Console.WriteLine(i.ToString());
            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 0; i <= tamanhoTurma; i++) {
                Console.WriteLine("Informe a nota do aluno {0}", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;

                double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
                Console.WriteLine("Média da turama: {0}", media);

            }
        }
    }
}
