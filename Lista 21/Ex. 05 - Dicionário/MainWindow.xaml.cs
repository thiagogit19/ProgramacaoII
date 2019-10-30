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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dicionário<int, string> x = new Dicionário<int, string>();
                x.Add(int.Parse(chaveAdd.Text), valorAdd.Text);
                ListC.ItemsSource = null;
                ListV.ItemsSource = null;
                ListC.ItemsSource = x.Chaves;
                ListV.ItemsSource = x.Valores;
            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine("Chave e/ou valor inválido.");
            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine("A chave já existe");
            }  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListC.ItemsSource = null;
            ListV.ItemsSource = null;
        }
    }
}
