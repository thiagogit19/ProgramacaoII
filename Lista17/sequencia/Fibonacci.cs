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

        public void Iniciar()
        {
            quant = q;
        }

        public int Proximo()
        {
            int num1 = 0;
            int num2 = 1;
            int aux;
            for (int i = 0; i < quant; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
            }

            return num2;

        }


    }
}
