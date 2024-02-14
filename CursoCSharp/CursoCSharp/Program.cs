using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

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
                {"Estruturas de Controles - Estrutura If/Else", EstruturaIfElse.Executar},
                {"Estruturas de Controles - Estrutura If/Else/ElseIf", EstruturaIfElseIf.Executar},
                {"Estruturas de Controles - Estrutura Switch", EstruturaSwitch.Executar},
                {"Estruturas de Controles - Estrutura While", EstruturaWhile.Executar},
                {"Estruturas de Controles - Estrutura DoWhile", EstruturaDoWhile.Executar},
                {"Estruturas de Controles - Estrutura For", EstruturaFor.Executar},
                {"Estruturas de Controles - Estrutura ForEach", EstruturaForEach.Executar},
                {"Estruturas de Controles - Usando Break", UsandoBreak.Executar},
                {"Estruturas de Controles - Usando Continue", UsandoContinue.Executar},

                //Classes e Métodos
                {"Classes e Métodos - Membros", Membros.Executar},
                {"Classes e Métodos - Construres", Construtores.Executar},
                {"Classes e Métodos - Métodos Com Retorno", MetodosComRetorno.Executar},
                {"Classes e Métodos - Métodos Estáticos", MetodosEstaticos.Executar},
                {"Classes e Métodos - Atributos Estáticos", AtributosEstaticos.Executar},
                {"Classes e Métodos - Desafio Atributo", DesafioAtributo.Executar},
                {"Classes e Métodos - Params", Params.Executar},
                {"Classes e Métodos - Parâmetros Nomeados", ParametrosNomeados.Executar},
                {"Classes e Métodos - Get e Set", GetSet.Executar},
                {"Classes e Métodos - Props", Props.Executar},
                {"Classes e Métodos - Read Only", Readonly.Executar},
                {"Classes e Métodos - Exemplo Enum", ExemploEnum.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}