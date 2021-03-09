using System;

namespace Polimorfismo
{

    // Polimorfismo é o principio pelo qual uma ou mais classes derivadas de uma mesma classe base
    // podem chamar métodos de mesma assinatura mas com comportamentos diferentes, especializados
    // para cada classe derivada e usando uma referência ao objeto da superclasse
    abstract public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine("Área: " + area);
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); // Reaproveitando o código da classe base
            Console.WriteLine("Desenhando um círculo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Área do círculo: " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); // Reaproveitando o código do método da classe base
            Console.WriteLine("Desenhando um retângulo");
        }

        public override void Area()
        {
            base.Area();
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); // Reaproveitando o código da classe base
            Console.WriteLine("Desenhando um triângulo");
        }

        public override void Area()
        {
            double area = (Largura * Altura) / 2;
            Console.WriteLine("Área do triângulo: " + area);
        }
    }
}
