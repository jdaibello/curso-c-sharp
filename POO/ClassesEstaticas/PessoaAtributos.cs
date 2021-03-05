using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEstaticas
{

    // Uma classe parcial pode ser dividida em várias partes
    // Um exemplo é deixar os atributos da classe em um arquivo 
    // e os métodos da mesma classe em outro arquivo
    partial class Pessoa
    {
        // Pode ser estático pois pode ser usado em outros pontos da aplicação e não na instância de uma classe
        public static int maioridade = 18;

        public string nome;
        public int idade;
    }
}
