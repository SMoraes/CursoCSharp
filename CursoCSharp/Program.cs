using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

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
                {"Metodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"GetSet - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"ExemploStruct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Class - Classes e Métodos", StructVsClass.Executar},
                {"Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrao - Classes e Métodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"ColecoesStack - Coleções", ColecoesStack.Executar},
                {"ColecoesDictionary - Coleções", ColecoesDictionary.Executar},

                // OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Selead - OO", Selead.Executar},

                //  Metodos e Funções
                {"Exemplo Lambda   - Métodos & Funções", ExemploLambda.Executar},
                {"Lambdas Com  Delegates - Métodos & Funções", LambdaDelegate.Executar},
                {"Usando Delegates - Métodos & Funções", UsandoDelegate.Executar},
                {"Delegates Como Função Anonimas - Métodos & Funções", DelegateFunAnonima.Executar},
                {"Delegates Como Parâmetros- Métodos & Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar},

                // Exceções
                {"Primeira Excecao - Exceções", PrimeiraExcecao.Executar},
                {"Excecoes Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                // Api
                {"Primeiro Arquivo - Api", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Api", LendoArquivos.Executar},
                {"Exemplo FileInfo - Api", ExemploFileInfo.Executar},
                {"Diretorios - Api", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Api", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Api", ExemploPath.Executar},
                {"Exemplo DateTime - Api", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Api", ExemploTimeSpan.Executar},

                // LINQ Topicos Avançados
                {"LINQ #01 Tópicos Avançados - Api", LINQ1.Executar},
                {"LINQ #02 Tópicos Avançados - Api", LINQ2.Executar},
                {"Nullables Tópicos Avançados - Api", Nullables.Executar},
                {"Dynamics Tópicos Avançados - Api", Dynamics.Executar},
                {"Genericos Tópicos Avançados - Api", Genericos.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}