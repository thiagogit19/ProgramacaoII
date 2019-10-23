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

namespace Ex._07
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

        private void OpenVeiculo(object sender, RoutedEventArgs e)
        {
            VeiculoWindow wpf2 = new VeiculoWindow();

            if (wpf2.ShowDialog().Value)
            {
                j.Inserir(wpf2.GetVeiculo());
            }
        }

        loja j;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            j = new loja(nome.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List.ItemsSource = j.ListarPorFabricante();
        }
    }
}
