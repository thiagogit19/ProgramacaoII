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
            Random r = new Random();
            n = r.Next(1, 60);
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
