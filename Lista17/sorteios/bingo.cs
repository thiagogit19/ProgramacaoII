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
        private int[] vetor;
        // private int c;

        public void SetNum(int m)
        {
            NumBolas = m;
        }

        public int GetNum()
        {
            return NumBolas;
        }

        public int Sortear()
        {
            int j = 0;
            Random r = new Random();
            while (j < NumBolas)
            {
                int n = r.Next(1, 60);
            }

            return 0;
            
        }

        public int[] Sorteados()
        {
            vetor = new int[NumBolas];
            for (int i = 1; i <= NumBolas; i++)
            {
                vetor[i] = n;
            }
            return vetor;
        }
    }
}
