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

        ISorteio s;
        private void Button_Click(object sender, RoutedEventArgs e) // Sortear 1
        {
            bingo b = new bingo();
            b.SetNum(int.Parse(num.Text));
            s = b as ISorteio;
            numsorte.Text = b.Sortear().ToString();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e) // Sortear 2
        {
            mega m = new mega();
            s = m as ISorteio;
            numsorte2.Text = m.Sortear().ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            sorteados1.Text = "";
            int[] v = s.Sorteados();
            foreach (int i in v)
            {
                sorteados1.Text += i.ToString();
                sorteados1.Text += " ";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            sorteados1.Text = "";
            int[] v = s.Sorteados();
            foreach(int i in v)
            {
                sorteados1.Text += i.ToString();
                sorteados1.Text += " ";
            }
        }
    }
}
