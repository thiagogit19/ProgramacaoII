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

namespace Ex._08___wpf
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

        estoque e = new estoque();

        private void ListarDescricaoClick(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = e.ListarDescricao();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = e.ListarPreco();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = e.Vencidos();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = e.AVencer(int.Parse(dias.Text));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = e.EstoqueBaixo(int.Parse(qtd.Text));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(e.total().ToString(), "Total em R$");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            e.excluir(lista.SelectedItem as produto);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ProdutoWindow j2 = new ProdutoWindow();
            if (j2.ShowDialog().Value)
            {
                es.Inserir(j2.GetProduto());
            }
        }
    }
}
