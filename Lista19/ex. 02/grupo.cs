using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._02
{
    class grupo
    {
        private string descricao;
        private contato[] contatos = new contato[100];
        private int k;

        public grupo(string d)
        {
            descricao = d;
        }

        public void adicionar(contato c)
        {
            if (k < 100) contatos[k++] = c;
        }

        public void excluir(contato c)
        {
            int x = Array.IndexOf(contatos, c);

            for (int i = x; i < k; i++)
            {
                contatos[i] = contatos[i + 1];
            }
            k--;
        }

        public contato[] listarcontato()
        {
            contato[] novo = new contato[k];
            Array.Copy(contatos, novo, k);
            return novo;
        }

        public override string ToString()
        {
            return $"{descricao}";
        }
    }
}
