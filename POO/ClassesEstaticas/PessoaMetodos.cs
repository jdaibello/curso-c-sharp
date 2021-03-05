using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEstaticas
{
    partial class Pessoa
    {
        public void Apresentar()
        {
            Console.WriteLine("Olá eu sou " + nome);
        }

        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
