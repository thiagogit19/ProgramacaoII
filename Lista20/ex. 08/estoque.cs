﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._08
{
    class estoque
    {
        private List<produto> produtos = new List<produto>();

        public void Inserir(produto p)
        {
            produtos.Add(p);
        }

        public void Excluir(produto p)
        {
            produtos.Remove(p);
        }

        public produto[] ListarDescricao()
        {
            produto[] ld = produtos.OrderBy(produto => produto.Descricao).ToArray();
            return ld;
        }

        public produto[] ListarPreco()
        {
            produto[] lp = produtos.OrderBy(produto => produto.Preco).ToArray();
            return lp;
        }

        public produto[] Vencidos()
        {
            List<produto> vencidos = new List<produto>();
            foreach (produto p in produtos)
            {
                if (p.GetVencido() == true) vencidos.Add(p);
            }
            return vencidos.ToArray();
        }

        public produto[] AVencer(int dias)
        {
            TimeSpan ts = new TimeSpan(dias, 0, 0, 0);
            DateTime dt = DateTime.Now;
            dt += ts;
            List<produto> novo = new List<produto>();
            foreach (produto p in produtos)
            {
                if (p.Validade <= dt.Date) novo.Add(p);
            }
            produto[] vet = novo.ToArray();
            return vet;
        }

        public decimal Total()
        {
            decimal z = 0;
            foreach (produto p in produtos)
            {
                z = z + p.GetPreco();
            }
            return z;
        }
    }
}
