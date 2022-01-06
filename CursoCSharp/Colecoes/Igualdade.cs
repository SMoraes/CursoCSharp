using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            // Atribuição por referência
            // Eles apontam para o mesmo local de memória.
            var p3 = p2;

            // Ele esta comparando referência de memória. Locais de memórias diferentes. 
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);

            /* Os valores do produtos são iguais. Não quero comparar um produto em termos de endereço
             * de memória mas sim por valores. 
             */
  
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
