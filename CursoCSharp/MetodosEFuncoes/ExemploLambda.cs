using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
   public class ExemploLambda
    {
        public static void Executar()
        {
            /*
             *  => Anotação
             * () => {} Função lambda, função anonima.
             *  Action: Função que não tem retorno.
             */
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com c#!");     
            };

            algoNoConsole();

            /*
             * Func: Função que tem retorno.
             */
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(1,1,2019));


        }
    }
}
