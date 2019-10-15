using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._07
{
    class veiculo : IComparable
    {
        private string placa, fabricante, modelo;
        private int ano;
        private decimal preco;
        private bool vendido;

        public string Placa { get => placa; }

        public string Fabricante { get => fabricante; }

        public string Modelo { get => modelo;  }

        public veiculo(string p, string f, string m, int a, decimal pr)
        {
            placa = p;
            fabricante = f;
            modelo = m;
            ano = a;
            preco = pr;
        }

        public decimal GetPreco()
        {
            return preco;
        }

        public void Vender()
        {
            if (vendido == false)
            {
                vendido = true;
            }
        }

        public bool GetVendido()
        {
            return vendido;
        }

        public int CompareTo(object obj)
        {
            veiculo outro = obj as veiculo;
            if (fabricante != outro.fabricante)
                return fabricante.CompareTo(outro.fabricante);
            return modelo.CompareTo(outro.modelo);
        }
    }
}
