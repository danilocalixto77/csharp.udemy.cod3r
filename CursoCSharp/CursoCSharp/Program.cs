using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        public static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Fundamentos - Primeiro Programa", PrimeiroPrograma.Executar},
                {"Fundamentos - Comentários", Comentarios.Executar},
                {"Fundamentos - Variáveis e Constantes", VariaveisEConstantes.Executar},
                {"Fundamentos - Inferência", Inferencia.Executar},
                {"Fundamentos - Interpolação", Interpolacao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}