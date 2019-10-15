using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._06
{
    class cliente
    {
        private string nome, cpf;
        private decimal limite;
        private List<cliente> socio = new List<cliente>();

        public string Nome
        {
            get => nome;
        }

        public string Cpf
        {
            get => cpf;
        }

        public List<cliente> Socio
        {
            get => socio;
        }

        public decimal Limite
        {
            get => limite;
        }

        public decimal LimiteTotal
        {
            get
            {
                decimal valor = 0;
                foreach (cliente c in socio)
                {
                    valor = valor + c.Limite;
                }
                return valor;
            }
        }

        public cliente(string n, string c, decimal l)
        {
            nome = n;
            cpf = c;
            limite = l;
        }

        public void Inserir(cliente c)
        {
            socio.Add(c);
        }

        public void Excluir(cliente c)
        {
            socio.Remove(c);
        }
    }
}
