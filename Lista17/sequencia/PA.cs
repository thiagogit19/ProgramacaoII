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

        public void Iniciar()
        {
            PrimeiroElemento = a1;
            razao = r;
        }

        public int Proximo()
        {
            return PrimeiroElemento + razao;
        }
    }
}
