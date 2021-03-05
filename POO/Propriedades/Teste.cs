﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Propriedades
{
    class Teste
    {
        // Definição de um campo / atributo
        private string _nome;
        public string Sobrenome { get; } = "Ipsum"; // A propriedade é o próprio campo

        private int _idade;

        // Definição de uma propriedade
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser inferior a 18 anos");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        public void Apresentar()
        {
            if (_nome != "")
            {
                Console.WriteLine("Bem vindo " + _nome);
            }
        }
    }
}
