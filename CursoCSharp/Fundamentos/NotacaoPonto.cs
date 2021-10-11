using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " Gabrielly").Replace("Gabrielly", "Adriano");

            Console.WriteLine(saudacao);

            Console.WriteLine("Adriano".Length);

            /*
             *  Atráves da Notação ponto conseguimos acessar funcionalidades, metodos e valores. 
             */

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
