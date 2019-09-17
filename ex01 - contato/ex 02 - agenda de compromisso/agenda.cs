using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02___agenda_de_compromisso
{
    class agenda
    {
        private compromisso[] comp = new compromisso[100];
        private int k;
        private int j; // quantidade de eventos

        public void Inserir(compromisso x){
            if (k < 10) comp[k++] = x;
            j += 1;
        }

        public compromisso[] Listar()
        {
            compromisso[] novo = new compromisso[k];
            Array.Copy(comp, novo, k);
            return novo;
        }

        public void Excluir (int w){
            for (int i = w; i < k; i++) // (w) É O ÍNDICE
            {
                comp[i] = comp[i + 1];
            }
            k--;
            j -= 1;
        }

        public compromisso[] Pesquisar(int m, int a)
        {
            int y = 0;
            compromisso[] vetor = new compromisso[k];

            for (int i = 0; i < k; i++)
            {
                if (comp[i].Data.Month == m && comp[i].Data.Year == a)
                {
                    vetor[y++] = comp[i];
                }
            }

            compromisso[] vetor2 = new compromisso[y];
            Array.Copy(vetor, vetor2, y);
            return vetor2;
        }  
    }
}
