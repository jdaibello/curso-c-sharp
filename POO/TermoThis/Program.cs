using System;

namespace TermoThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            if (a.Login("12e23rfr4235r"))
            {
                Console.WriteLine("Seja bem-vindo");
            }
            Console.WriteLine("Acesso negado");

            Console.ReadKey();
        }
    }
}
