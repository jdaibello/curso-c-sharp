using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesObjetos
{
    class Pessoa
    {

        // Atributos ou campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        // Métodos simples
        // Método void não tem retorno
        public void Cumprimentar()
        {
            Console.WriteLine("Olá eu sou " + nome + " " + sobrenome);
        }
    }
}
