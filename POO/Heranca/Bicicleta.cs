using System;

namespace Heranca
{
    class Bicicleta : Veiculo // Classe Bicicleta vai herdar da classe Veiculo
    {

        public override void Acelerar() // O método abstrato está sendo sobrescrito
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a bicicleta!");
        }

        public void Pedalar()
        {
            Console.WriteLine("Você começou a pedalar a bicicleta");
        }
    }
}
