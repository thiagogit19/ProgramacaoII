using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05___livraria
{
    class Livraria
    {
        private string nome;
        private Livro[] livros = new Livro[50];
        private int k;

        public int Qtd
        {
            get => k;
        }

        public Livraria(string nome)
        {
            this.nome = nome;
        }

        public void Inserir(Livro l)
        {
            if (k < 50) livros[k++] = l;
        }

        public void Remover(int n)
        {
            if (n < k)
            {
                for (int i = n + 1; i < k; i++)
                    livros[i - 1] = livros[i];
                k--;
            }
        }

        public Livro[] Listar()
        {
            Livro[] novo = new Livro[k];
            Array.Copy(livros, novo, k);
            Array.Sort(novo, new TituloComp());
            return novo;
        }

        public Livro[] ListarGenero()
        {
            Livro[] novo = new Livro[k];
            Array.Copy(livros, novo, k);
            Array.Sort(novo, new GeneroComp());
            return novo;
        }

        public Livro[] Top10Vendidos()
        {
            Livro[] novo = new Livro[k];
            Array.Copy(livros, novo, k);
            Array.Sort(novo);

            if (k > 10)
            {
                Livro[] novo2 = new Livro[10];
                Array.Copy(novo, novo2, 10);
                return novo2;
            }
            return novo;
        }

        public override string ToString()
        {
            return $"{nome}";
        }

        public void Vender(int n)
        {
            if (n < k) livros[n].Vender();
        }
    }
}
