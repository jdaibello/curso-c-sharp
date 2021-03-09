using System;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            /*MinhaClasse mClasse = new MinhaClasse();
            MinhaClasse m2 = null;

            OutraClasse outra = new OutraClasse();
            OutraClasse outra2 = outra; // 'outra2' recebe a referência da classe 'outra'
            */
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Fuu";
            p1.sobrenome = "Bar";
            p1.anoNascimento = 1985;

            Pessoa p2 = new Pessoa()
            {
                nome = "Lorem",
                sobrenome = "Ipsum",
                anoNascimento = 2011
            };

            p1.nome = "Foo";

            Console.WriteLine("Nome pessoa 1: " + p1.nome);
            Console.WriteLine("Sobrenome pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Ano de nascimento pessoa 1: " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Nome pessoa 2: " + p2.nome);
            Console.WriteLine("Sobrenome pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Ano de nascimento pessoa 2: " + p2.anoNascimento);
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }
}
