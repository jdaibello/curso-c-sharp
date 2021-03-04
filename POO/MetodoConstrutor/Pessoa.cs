using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoConstrutor
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        // Sempre public / comportamento quando a classe for instânciada
        public Pessoa()
        {
            nome = "Fuu";
            sobrenome = "Bar";
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobrenome, int anoNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            idade = Idade();
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = 2003;
            idade = Idade();
        }

        private int Idade()
        {
            return 2021 - anoNascimento;
        }
    }
}
