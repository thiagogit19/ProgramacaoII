using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04___aplicativo
{
    class aplicativo : IComparable
    {
        private string nome;
        private string categoria;
        private double preco;
        private int curtidas;

        public int Curtidas
        {
            get; set;
        }

        public string Nome
        {
            get; set;
        }

        public aplicativo(string n, string c, double p)
        {
  
        }

        public void Curtir()
        {

        }

        public override string ToString()
        {
            return $"{nome} - {categoria} - {preco}";
        }

        public void SetCategoria(string c)
        {
            categoria = c;
        }

        public string GetCategoria()
        {
            return categoria;
        }

        public int CompareTo(object obj)
        {
            return nome.CompareTo(((aplicativo)obj).Nome);
        }
    }
}
