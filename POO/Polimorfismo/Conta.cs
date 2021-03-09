namespace Polimorfismo
{

    // A classe CaixaEletronico está herdando a interface IConta
    class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar()
        {
            
        }

        public void Sacar()
        {
            
        }

        public void Saldo()
        {
            
        }

        public void SolicitarEmprestimo()
        {

        }
    }

    // Uma interface é como se fosse uma classe (mas não é) TOTALMENTE abstrata
    // Todos os métodos já são abstratos
    // Todas as classes que herdarem a interface são obrigadas a impletentar todos seus membros
    // As interfaces estão diretamento ligadas ao polimorfismo pois nada dos membros estão sendo implementados
    // na própria classe, e sim na classe que está implementando a interface (CaixaEletronico) e cada membro
    // pode ter comportamento diferente dependendo da classe
    interface IConta
    {
        // Por padrão todos os métodos da interfac são públicos
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
