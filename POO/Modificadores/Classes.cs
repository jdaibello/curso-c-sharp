using System;
using System.Collections.Generic;
using System.Text;

namespace Modificadores
{
    class Teste
    {
        // O modificador public define que determinados membros da classe
        // ficam visíveis/acessíveis tanto nas intâncias quanto em heranças

        // O modificador private define que determinados membros da classe
        // serão visíveis/acessíveis somente dentro da própria classe
        private string nome;
        public string sobrenome;

        private void Metodo1() { }

        public void Executar() { }
    }

    class Humano
    {
        // O modificador protected define que determinados membros da classe
        // ficam visíveis/acessíveis em heranças, mas não em instâncias
        protected string nome;
        private string sobrenome;

        // O modificador internal define que determinados membros da classe
        // ficam visíveis/acessíveis na aplicação, mas não em DLLs (bibliotecas)
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
