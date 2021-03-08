using System;

namespace Heranca
{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        public abstract void Acelerar(); // Um método abstrato não pode conter implementação, ou seja, não tem comportamento definido

        public abstract void Parar();
    }
}
