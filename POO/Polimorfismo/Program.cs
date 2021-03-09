using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Forma a = new Forma();
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();

            // Console.WriteLine("Forma");
            // a.Desenhar();

            Console.WriteLine("Triângulo");
            b.Desenhar();

            Console.WriteLine("\nCírculo");
            c.Desenhar();

            Console.WriteLine("\nRetângulo");
            d.Desenhar();

            Console.ReadKey();
        }
    }
}
