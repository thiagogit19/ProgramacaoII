using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace loja
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        loja j;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            j = new loja(nome.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool ver = (check.IsChecked == true ? true : false);
            /*if (check.IsChecked == true) ver = true;
            else ver = false;*/
            j.Inserir(new veiculo(placa.Text, fab.Text, mod1.Text, ano.Text, decimal.Parse(preco.Text), ver));
            lista.ItemsSource = j.Listar();
        }
    }

    class veiculo
    {
        private string placa, fabricante, modelo;
        private string ano;
        private decimal preco;
        private bool vendido;
        private string situacao;

        public veiculo(string placa, string fabri, string mod, string ano, decimal preco, bool a)
        {
            this.placa = placa;
            fabricante = fabri;
            modelo = mod;
            this.ano = ano;
            this.preco = preco;
        }

        public decimal GetPreco()
        {
            return preco;
        }

        public bool GetVendido()
        {
            return vendido;
        }

        public void Vender()
        {
            if (vendido == true) situacao = "vendido";
            else situacao = "A venda";
        }

        public override string ToString()
        {
            return $"{modelo} - {fabricante} - {ano} - {situacao}";
        }
    }

    class loja
    {
        private string nome;
        private veiculo[] veiculos = new veiculo[15];
        private int k;

        public loja(string n)
        {
            nome = n;
        }

        public void Inserir(veiculo v)
        {
            if (k < 15) veiculos[k++] = v;
        }

        public veiculo[] Listar()
        {
            veiculo[] novo = new veiculo[k];
            Array.Copy(veiculos, novo, k);
            return novo;
        }

        public veiculo[] ListarValor(decimal valorMax)
        {
            int y = 0;
            veiculo[] vetor = new veiculo[k];
            for (int i = 0; i < k; i++)
            {
                if (veiculos[i].GetVendido() == false && veiculos[i].GetPreco() <= valorMax)
                {
                    vetor[y++] = veiculos[i];
                }
            }
            veiculo[] vetor2 = new veiculo[y];
            Array.Copy(vetor, vetor2, y);
            return vetor2;
        }

        public decimal total()
        {
            if (k == 0) return 0;
            decimal z = 0;

            foreach (veiculo d in veiculos)
                if (d != null) z = z + d.GetPreco();
            return z / k;
        }
    }
}
