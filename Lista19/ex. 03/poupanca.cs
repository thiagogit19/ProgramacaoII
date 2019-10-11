using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._03
{
    class Poupanca : ContaCorrente
    {
        public Poupanca(string t, string n) : base(t, n) { }

        public void Render(double juros)
        {
            base.saldo = base.saldo + juros * base.saldo;
        }
    }
}
