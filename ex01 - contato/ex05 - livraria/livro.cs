using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05___livraria
{
    class Livro : IComparable
    {
        private string titulo;
        private string genero;
        private double preco;
        private int vendidos;

        public int Vendidos
        {
            get => vendidos;
        }

        public string Titulo
        {
            get { return titulo; }
        }

        public Livro(string t, string g, double p)
        {
            titulo = t;
            genero = g;
            preco = p;
        }

        public void Vender()
        {
            vendidos++;
        }

        public override string ToString()
        {
            return $"{titulo} {genero} {preco} {vendidos}";
        }

        public string GetGenero()
        {
            return genero;
        }

        public int CompareTo(object obj)
        {
            Livro outro = obj as Livro;
            if (this.vendidos > outro.vendidos) return -1;
            if (this.vendidos < outro.vendidos) return 1;
            return this.titulo.CompareTo(outro.titulo);
        }
    }
}
