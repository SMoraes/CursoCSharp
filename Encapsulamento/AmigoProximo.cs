﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() 
        {
            Console.WriteLine("Amigo proximo...");
            Console.WriteLine();
        }
    }
}
