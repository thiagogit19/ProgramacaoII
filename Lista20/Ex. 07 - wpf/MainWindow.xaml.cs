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

namespace Ex._07___wpf
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

        private void OpenVeiculoWindow(object sender, RoutedEventArgs e)
        {
            VeiculoWindow j2 = new VeiculoWindow();
            if (j2.ShowDialog().Value)
            {
                j.Inserir(j2.GetVeiculo());
            }
        }

        loja j;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            j = new loja(nome.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            list1.ItemsSource = j.ListarPorFabricante();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            list1.ItemsSource = j.ListarPorModelo();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            list1.ItemsSource = j.BuscarValor(decimal.Parse(buscarpreco.Text));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(j.BuscarPlaca(buscarplaca.Text).ToString());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            (list1.SelectedItem as veiculo).Vender();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            j.Excluir(list1.SelectedItem as veiculo);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(j.total().ToString());
        }
    }
}
