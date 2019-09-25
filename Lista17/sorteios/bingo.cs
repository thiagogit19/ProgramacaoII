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
        private int c;

        
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
            vetor = new int[NumBolas];
            Random r = new Random(); 
            while (j < NumBolas)
            {
                int n = r.Next(1, NumBolas + 1);

                if (Array.IndexOf(vetor, n) == -1)
                {
                    vetor[j] = n;
                    j++;
                }
            }
            c = 0;

            if (c < NumBolas)
            {
                return vetor[c++];
            }
            else return 0;
        }

        public int[] Sorteados()
        {
            int[] vetor2 = new int[c];
            Array.Copy(vetor, vetor2, c);
            return vetor2; 
        }
    }
}
