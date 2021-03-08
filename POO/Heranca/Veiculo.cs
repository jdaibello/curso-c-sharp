namespace Heranca
{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        // Um método abstrato não pode conter implementação, ou seja, não tem comportamento definido
        // Um método só pode ser abstrato em uma classe que é abstrata
        public abstract void Acelerar();

        public abstract void Parar();
    }
}
