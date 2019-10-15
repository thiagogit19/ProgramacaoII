using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._08
{
    class produto
    {
        private string descricao;
        private decimal preco;
        private int qtd;
        private DateTime validade;

        public string Descricao { get => descricao; }

        public decimal Preco { get => preco; }

        public produto(string d, decimal p, int q, DateTime v)
        {
            descricao = d;
            preco = p;
            qtd = q;
            validade = v;
        }

        public decimal GetPreco()
        {
            return preco;
        }

        public bool GetVencido()
        {
            if (DateTime.Now > validade) return true;
            return false;
        }
    }
}
