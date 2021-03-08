using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class Humano
    {

        // Um método virtual pode ser sobrescrito e pode ter uma implementação base
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }

    class Pessoa : Humano
    {

        // O método não pode mais ser modificado
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }

    class Homem : Pessoa
    {

        // Vai dar erro
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }
    }
}
