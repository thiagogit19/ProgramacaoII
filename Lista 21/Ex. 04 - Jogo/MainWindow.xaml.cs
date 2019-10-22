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

namespace Ex._04___Jogo
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

        Jogo x;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = null;
            x = new Jogo(nomejogo.Text);
        }

        Jogador j;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                j = new Jogador(nome.Text, email.Text);
                j.SetPontos(int.Parse(pm.Text), DateTime.Parse(data.Text));
                x.Inserir(j);
            }

            catch (ArgumentOutOfRangeException a)
            {
                MessageBox.Show("Pontuação negativa e/ou data inválida");
            }

            catch (EmailExistenteException b)
            {
                MessageBox.Show("Este email cadastrado já existe");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = null;
            lista.ItemsSource = x.Listar();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = null;
            lista.ItemsSource = new Jogador[]{ x.Top1() };
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = null;
            lista.ItemsSource = x.Top10();
        }
    }
}
