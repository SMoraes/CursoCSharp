using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            //var palavra = "Opa!";
            //foreach (var letra in palavra)
            //{
            //    Console.WriteLine(letra);
            //}

            var alunos = new string[] { "Sergio", "Andrea", "Solony", "Gabrielly" };
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
