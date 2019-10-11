using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._02
{
    class usuario : contato
    {
        private contato[] contatos = new contato[100];
        private grupo[] grupos = new grupo[15];
        private int k, g;

        public usuario(string n, string f) : base(n, f) { }

        public override string ToString()
        {
            return $"grupos: {g} -- contatos: {k}";
        }

        public void Inserircontato(contato c)
        {
            if (k < 100) contatos[k++] = c;
        }

        public void Inserirgrupo(grupo gr)
        {
            if (g < 15) grupos[g++] = gr;
        }

        public contato[] listarcontatos()
        {
            contato[] vetorc = new contato[k];
            Array.Copy(contatos, vetorc, k);
            return vetorc;
        }

        public grupo[] listargrupos()
        {
            grupo[] vetorg = new grupo[k];
            Array.Copy(grupos, vetorg, k);
            return vetorg;
        }
    }
}
