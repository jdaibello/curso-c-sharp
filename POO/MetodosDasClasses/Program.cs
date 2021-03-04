using System;

namespace MetodosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Métodos simples
            Metodos m = new Metodos();
            m.Cumprimentar();
            #endregion

            #region Métodos com parâmetros
            m.Somar(10, 5);
            m.Apresentar("Oswaldo", 30);
            #endregion

            #region Passagem de parâmetros por valor e por referência
            int valor1 = 100;
            int valor2 = 100;

            m.AumentarPorValor(valor1); // Faz uma cópia do valor
            m.AumentarPorReferencia(ref valor2); // Faz uma referência do valor

            Console.WriteLine("Valor 1: " + valor1); // variável não foi afetada
            Console.WriteLine("Valor 2: " + valor2); // variável foi afetada 
            #endregion

            #region Métodos com retorno de valores
            string nomeCompleto = m.MontaNome("Foo", "Bar");
            int codigoChar = m.CodigoChar('W');
            double pi = m.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine("W: " + codigoChar);
            Console.WriteLine("PI = " + pi);
            #endregion

            #region Sobrecarga de métodos (overloading)
            m.Cumprimentar();
            m.Cumprimentar("João");
            m.Cumprimentar("João", 21);

            bool res1 = m.Comparar(100, 50 * 2);
            bool res2 = m.Comparar("João", "joão");

            Console.WriteLine(res1);
            Console.WriteLine(res2); 
            #endregion

            Console.ReadKey();
        }
    }
}
