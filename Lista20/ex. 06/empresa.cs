using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._06
{
    class empresa
    {
        private List<cliente> clientes = new List<cliente>();

        public void Inserir(cliente c)
        {
            clientes.Add(c);
        }

        public void Excluir(cliente c)
        {
            clientes.Remove(c);
        }

        public void Socios(cliente x, cliente y)
        {
            x.Inserir(y);
            y.Inserir(x);
        }

        public List<cliente> ListarNome()
        {
            List<cliente> ln = clientes.OrderBy(cliente => cliente.Nome).ToList();
            return ln;
        }

        public List<cliente> ListarLimite()
        {
            List<cliente> ll = clientes.OrderBy(cliente => cliente.Cpf).ToList();
            return ll;
        }

        public List<cliente> ListarNaoSocio()
        {
            List<cliente> naosocio = new List<cliente>();

            foreach (cliente c in clientes)
            {
                if (c.Socio == null) naosocio.Add(c);
            }
            return naosocio;
        }
    }
}
