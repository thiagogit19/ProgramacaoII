using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequencia
{
    class PA : ISequencia
    {
        private int PrimeiroElemento;
        private int razao;
        private int x;

        public PA(int p1, int r)
        {
            PrimeiroElemento = p1;
            razao = r;
        }

        public void Iniciar()
        {
            x = 0;
        }

        public int Proximo()
        {
            x++;
            if (x == 1) return PrimeiroElemento;
            if (x == 2) return PrimeiroElemento + razao;

            return PrimeiroElemento + razao * (x - 1);
        }
    }
}
