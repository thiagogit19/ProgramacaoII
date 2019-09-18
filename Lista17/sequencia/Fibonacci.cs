using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequencia
{
    class Fibonacci : ISequencia
    {
        private int quant;
        private int a = 0; 
        private int b = 1;

        public void Iniciar()
        {
            quant = 0;
        }

        public int Proximo()
        {
            if (quant == 1) return a;

            if (quant == 2) return b;
 
            int c = a + b;
            a = b;
            b = c;
            return c;
        }
    }
}
