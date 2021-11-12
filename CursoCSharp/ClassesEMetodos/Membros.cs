using System;


namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Adriano Moraes";
            sicrano.Idade = 28;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 19;

            var apresetacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresetacaoDoFulano.Length);
            Console.WriteLine(apresetacaoDoFulano);


        }
    }
}
