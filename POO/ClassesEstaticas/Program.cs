using System;

namespace ClassesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classe Estática
            // Não é possível instanciar uma classe estática
            // Um exemplo de uso de classe estática é quando queremos 
            // configurações que fiquem globais para acessar em toda nossa aplicação
            Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(200); // 210
            int valor2 = Matematica.Diminuir(200); // 190

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);
            #endregion

            #region Membros Estáticos
            // Acesso por referência e não por objetos instânciados
            // A partir de agora o valor da maioridade é maior
            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Pedro Álvares Cabral";
            p1.idade = Pessoa.CalcularIdade(1467);

            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Idade: " + p1.idade);
            Console.WriteLine("Maioridade: " + Pessoa.maioridade);
            #endregion

            Console.ReadKey();
        }
    }
}
