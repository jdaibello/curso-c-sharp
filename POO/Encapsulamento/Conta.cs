using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class Conta
    {
        // Atributos
        private string _cliente;
        private double _saldo;
        private double _taxa = 10;

        // Propriedades
        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if (value != "João" && value != "Fulano")
                {
                    _cliente = "Visitante";
                    _saldo = 0;
                }
                else
                {
                    _cliente = value;
                    _saldo = 100;
                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            private set
            {
                _saldo = 0;
            }
        }

        // Métodos
        public void Sacar(double valor)
        {
            valor += _taxa;
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }
    }
}
