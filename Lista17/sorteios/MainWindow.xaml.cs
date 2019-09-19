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

namespace sorteios
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

        bingo b;
        private void Button_Click(object sender, RoutedEventArgs e) // Sortear 1
        {
            lista1.Items.Clear();
            b = new bingo();
            b.SetNum(int.Parse(num.Text));
            lista1.Items.Add(b.Sortear());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // Sorteados 1
        {
            lista1.ItemsSource = b.Sorteados();
        }

        mega m;
        private void Button_Click_1(object sender, RoutedEventArgs e) // Sortear 2
        {
            lista2.Items.Clear();
            for (int j = 1; j <= 6; j++)
            {
                m = new mega();
                lista2.Items.Add(m.Sortear());
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // Sorteados 2
        {
            lista2.ItemsSource = b.Sorteados();
        }
    }
}
