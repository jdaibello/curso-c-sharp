using System;

namespace Heranca
{
    class Carro : Veiculo // Classe Carro vai herdar da classe Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Você ligou o motor do carro");
        }
    }
}
