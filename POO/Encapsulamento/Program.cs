using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "João";
            Console.WriteLine("Saldo inicial: R$ " + c.Saldo);

            //==== Operação de Depósito ====
            double valor = 100;
            c.Depositar(valor);
            Console.WriteLine("Saldo após depósito: R$ " + c.Saldo);

            //==== Operação de Saque ====
            double valor2 = 50;
            c.Sacar(valor2); // valor + taxa <- 60
            Console.WriteLine("Saldo após saque: R$ " + c.Saldo);

            //==== Resultado do Saldo Atual ====
            Console.WriteLine();
            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo final: R$ " + c.Saldo);

            Console.ReadKey();
        }
    }
}
