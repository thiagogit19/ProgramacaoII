using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._03
{
    class ContaCorrente
    {
        private string titular;
        private string numeroConta;
        protected double saldo;

        public ContaCorrente(string t, string n)
        {
            titular = t;
            numeroConta = n;
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > saldo) return false;

            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public double RetornarSaldo()
        {
            return saldo;
        }

        public override string ToString()
        {
            return $"{titular} - {numeroConta} - {saldo}";
        }
    }
}
