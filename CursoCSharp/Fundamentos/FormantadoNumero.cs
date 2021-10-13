using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace CursoCSharp.Fundamentos
{
    class FormantadoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo culture = new CultureInfo("pt-BR");

            Console.WriteLine("C3", culture);

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));

            
        }
    }
}
