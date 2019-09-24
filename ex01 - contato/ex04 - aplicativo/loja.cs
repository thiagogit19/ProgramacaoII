using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04___aplicativo
{
    class loja
    {
        private string nome;
        private aplicativo[] apps = new aplicativo[500];
        private int k;

        public int Qtd
        {
            get => k;
        }

        public loja(string n)
        {
            nome = n;
        }

        public void Inserir(aplicativo app)
        {
            if (k < 500) apps[k++] = app;
        }

        public void Remover(aplicativo app)
        {
            int w = Array.IndexOf(apps, app);

            for (int i = w; i < k; i++)
            {
                apps[i] = apps[i + 1];
            }
            k--;
        }

        public aplicativo[] Listar()
        {
            aplicativo[] novo = new aplicativo[k];
            Array.Copy(apps, novo, k);
            return novo;
        }

        public aplicativo[] ListarCategoria(string c)
        {
            
}
        }

        public aplicativo[] Top10Curtidas()
        {
            aplicativo[] vetor = new aplicativo[k];
            Array.Copy(apps, vetor, k);
            Array.Sort(vetor);

            if (k > 10)
            {
                aplicativo[] vetor2 = new aplicativo[10];
                Array.Copy(vetor, vetor2, 10);
                return vetor2;
            }
            return vetor;
        }
}

