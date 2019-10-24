using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._08___wpf
{
    class produto
    {
        private string descricao;
        private decimal preco;
        private int qtd;
        private DateTime validade;

        public string Descricao { get => descricao; }

        public decimal Preco { get => preco; }

        public DateTime Validade { get => validade; }

        public int Qtd { get => qtd; }

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

        public override string ToString()
        {
            return $"{descricao} - {preco} - {qtd} - {validade}";
        }
    }
}
