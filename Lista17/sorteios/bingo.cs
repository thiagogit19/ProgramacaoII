using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorteios
{
    class bingo : ISorteio
    {
        private int NumBolas;

        public void SetNum(int m)
        {
            NumBolas = m;
        }

        public int GetNum()
        {
            return NumBolas;
        }

        int n;
        public int Sortear()
        {
            Random r = new Random();
            n = r.Next(1, 60);
            return n;
        }

        public int[] Sorteados()
        {
            int[] vetor = new int[NumBolas];
            for (int i = 1; i <= NumBolas; i++)
            {
                vetor[i] = n;
            }
            return vetor;
        }
    }
}
