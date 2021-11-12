using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formantado Numero - Fundamentos", FormantadoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"OperadoresAritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"OperadoresRelacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"OperadoresLogicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadore Ternario - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IfElse - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura EstruturaIFElseIf - Estruturas de Controle", EstruturaIFElseIf.Executar},
                {"Estrutura EstruturaSwitch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura EstruturaWhile - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura EstruturaDoWhile - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura EstruturaFor - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura EstruturaForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Estrutura UsandoBreak - Estruturas de Controle", UsandoBreak.Executar},
                {"Estrutura UsandoContinue - Estruturas de Controle", UsandoContinue.Executar},

                // Classes e Métodos
                {"Membro - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}