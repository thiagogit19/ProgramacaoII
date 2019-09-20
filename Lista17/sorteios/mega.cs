using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorteios
{
    class mega : ISorteio
    {
        int n;
        public int Sortear()
        {
            int j = 0;
            Random r = new Random();
            while (j < 6) {
               n = r.Next(1, 60);
               j++;
            }
            return n;
        }

        public int[] Sorteados()
        {
            int[] vetor = new int[5];
            for (int i = 1; i <= 5; i++)
            {
                vetor[i] = n;
            }
            return vetor;
        }
    }
}
