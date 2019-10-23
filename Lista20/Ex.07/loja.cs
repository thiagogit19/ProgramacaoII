using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._07
{
    class loja
    {
        private string nome;
        private List<veiculo> veiculos = new List<veiculo>();

        public loja(string n)
        {
            nome = n;
        }

        public void Inserir(veiculo v)
        {
            veiculos.Add(v);
        }

        public void Excluir(veiculo v)
        {
            veiculos.Remove(v);
        }

        public veiculo[] ListarPorFabricante()
        {
            veiculo[] lf = veiculos.OrderBy(veiculo => veiculo.Fabricante).ToArray();
            return lf;
        }

        public veiculo[] ListarPorModelo()
        {
            veiculo[] lm = veiculos.OrderBy(veiculo => veiculo.Modelo).ToArray();
            return lm;
        }

        public decimal total()
        {
            decimal z = 0;

            foreach (veiculo d in veiculos)
                if ((d != null) && (d.GetVendido() == false)) z = z + d.GetPreco();
            return z;
        }

        public veiculo BuscarPlaca(string p)
        {
            foreach (veiculo v in veiculos)
                if (v.Placa == p) return v;
            return null;
        }


        public veiculo[] BuscarValor(decimal precoMax)
        {
            int y = 0;
            veiculo[] vetor = new veiculo[veiculos.Count];
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i].GetVendido() == false && veiculos[i].GetPreco() <= precoMax)
                {
                    vetor[y++] = veiculos[i];
                }
            }
            veiculo[] vetor2 = new veiculo[y];
            Array.Copy(vetor, vetor2, y);
            return vetor2;
        }
    }
}