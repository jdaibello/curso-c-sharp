using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();

            Console.WriteLine("Carro");

            c.Cor = "Branca";
            c.Marca = "Nova marca";
            c.VelocidadeMaxima = 150;
            
            Console.WriteLine("Cor: " + c.Cor + "\nMarca: " + c.Marca + "\n" +
                              "Vel. Máxima: " + c.VelocidadeMaxima + " Km/h");
            c.LigarMotor();
            c.Acelerar();
            c.Parar();

            Console.WriteLine("\nBicicleta");

            b.Cor = "Azul";
            b.Marca = "Bike Max";

            Console.WriteLine("Cor: " + b.Cor + "\nMarca: " + b.Marca);
            b.Pedalar();
            c.Acelerar();
            c.Parar();

            Console.ReadKey();
        }
    }
}
