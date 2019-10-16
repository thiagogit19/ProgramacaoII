using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._03
{
    class Conta_Bancaria
    {
        private string numero;
        private decimal saldo;

        public Conta_Bancaria (string n, decimal s)
        {
            numero = n;
            saldo = s;
        }

        public void Depositar(decimal valor)
        {
            if (valor < 0) throw new ArgumentOutOfRangeException();
            else saldo = saldo + valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor < 0) throw new ArgumentOutOfRangeException();
            if (valor > saldo) throw new InversaoSaldoException();
            else saldo = saldo - valor;
        }

        public decimal Saldo()
        {
            return saldo;
        }

        public override string ToString()
        {
            return $"{numero} - {saldo}";
        }
    }
}
