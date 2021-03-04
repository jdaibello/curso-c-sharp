using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEstaticas
{
    static class Matematica // Todos os membros de uma classe estática devem ser estáticos 
    {
        public static int taxa;

        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }
    }
}
