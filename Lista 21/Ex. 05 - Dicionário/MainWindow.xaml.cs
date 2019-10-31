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

namespace Ex._05___Dicionário
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

        Dicionário<int, string> x = new Dicionário<int, string>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                x.Add(int.Parse(chaveAdd.Text), valorAdd.Text);
                ListC.ItemsSource = null;
                ListV.ItemsSource = null;
                ListC.ItemsSource = x.Chaves;
                ListV.ItemsSource = x.Valores;
            }

            catch (ArgumentNullException erro)
            {
                Console.WriteLine("Chave e/ou valor inválido.");
            }

            catch (InvalidOperationException erro)
            {
                Console.WriteLine("A chave já existe");
            }  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            x.Clear();
            ListC.ItemsSource = null;
            ListV.ItemsSource = null;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (x.Contains(int.Parse(contem.Text)) == true)
            {
                MessageBox.Show("Contém a chave");
            }

            else MessageBox.Show("Não contém");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            x.Remove(int.Parse(remover.Text));
            ListC.ItemsSource = null;
            ListV.ItemsSource = null;
            ListC.ItemsSource = x.Chaves;
            ListV.ItemsSource = x.Valores;
        }
    }
}
