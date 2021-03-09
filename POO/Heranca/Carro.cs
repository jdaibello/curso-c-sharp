﻿using System;

namespace Heranca
{
    class Carro : Veiculo // Classe Carro vai herdar da classe Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }

        public void LigarMotor()
        {
            Console.WriteLine("Você ligou o motor do carro");
        }
    }
}
