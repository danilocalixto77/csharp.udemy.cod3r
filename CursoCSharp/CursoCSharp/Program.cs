using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        public static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Fundamentos - Primeiro Programa", PrimeiroPrograma.Executar},
                {"Fundamentos - Comentários", Comentarios.Executar},
                {"Fundamentos - Variáveis e Constantes", VariaveisEConstantes.Executar},
                {"Fundamentos - Inferência", Inferencia.Executar},
                {"Fundamentos - Interpolação", Interpolacao.Executar},
                {"Fundamentos - Notação Ponto", NotacaoPonto.Executar},
                {"Fundamentos - Lendo Dados", LendoDados.Executar},
                {"Fundamentos - Formatando Números", FormatandoNumeros.Executar},
                {"Fundamentos - Conversões", Conversoes.Executar},
                {"Fundamentos - Operadores Aritiméticos", OperadoresAritimeticos.Executar},
                {"Fundamentos - Operadores Relacionais", OperadoresRelacionais.Executar},
                {"Fundamentos - Operadores Logicos", OperadoresLogicos.Executar},
                {"Fundamentos - Operadores Atribuições", OperadoresAtribuicao.Executar},
                {"Fundamentos - Operadores Unários", OperadoresUnarios.Executar},
                {"Fundamentos - Operadores Ternario", OperadorTernario.Executar},
                //Estruturas de Controles
                {"Estruturas de Controles - Estrutura If", Estruturaif.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}