using System;
using System.Collections.Generic;
using System.Text;

namespace TipoDelegate
{
    class Matematica
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine("A soma é: " + (n1 + n2));
        }

        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("A subtração é: " + (n1 - n2));
        }

        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine("A multiplicacão é: " + (n1 * n2));
        }

        public void Dividir(int n1, int n2)
        {
            Console.WriteLine("A divisão é: " + (n1 / n2));
        }
    }
}
