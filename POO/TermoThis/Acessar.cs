using System;
using System.Collections.Generic;
using System.Text;

namespace TermoThis
{
    class Acessar
    {
        string senha /*a_senha*/ = "xyz";

        public bool Login(string senha /*p_senha*/)
        {
            // return a_senha == p_senha;
            return this.senha == senha; // this.senha: Instância da classe / senha: Parâmetro do método
        }
    }
}
