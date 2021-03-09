using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();
            ///* Veiculo v = new Veiculo(); // Uma classe abstrata não pode ser instânciada */

            //Console.WriteLine("Carro");

            //c.Cor = "Branca";
            //c.Marca = "Nova marca";
            //c.VelocidadeMaxima = 150;

            //Console.WriteLine("Cor: " + c.Cor + "\nMarca: " + c.Marca + "\n" +
            //                  "Vel. Máxima: " + c.VelocidadeMaxima + " Km/h");
            //c.LigarMotor();
            //c.Acelerar();
            //c.Parar();

            //Console.WriteLine("\nBicicleta");

            //b.Cor = "Azul";
            //b.Marca = "Bike Max";

            //Console.WriteLine("Cor: " + b.Cor + "\nMarca: " + b.Marca);
            //b.Pedalar();
            //b.Acelerar();
            //b.Parar();
            #endregion

            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("Humano");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa");
            b.Olhos();
            b.Cabelos();

            Console.WriteLine("\nHomem");

            // Está como sealed da classe Pessoa, portanto não pode ser sobrescrito
            // O método foi herdado da classe Pessoa
            // out: Pessoa.Olhos
            c.Olhos();
            c.Cabelos();

            Console.ReadKey();
        }
    }
}
