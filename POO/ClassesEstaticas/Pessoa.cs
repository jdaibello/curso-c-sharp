using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEstaticas
{
    class Pessoa
    {
        // Pode ser estático pois pode ser usado em outros pontos da aplicação e não na instância de uma classe
        public static int maioridade = 18;

        public string nome;
        public int idade;

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
