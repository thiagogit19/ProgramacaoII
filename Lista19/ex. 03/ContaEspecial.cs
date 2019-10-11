using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._03
{
    class ContaEspecial : ContaCorrente
    {
        private double limite;

        public ContaEspecial(string t, string n, double l) : base(t, n)
        {
            limite = l;
        }

        public override bool Sacar(double valor)
        {
            if (valor > limite + saldo) return false;

            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
    }
}
