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

namespace ex_02___agenda_de_compromisso
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

        agenda a = new agenda();
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            compromisso x = new compromisso();
            x.Assunto = assunto.Text;
            x.Local = local.Text;
            x.Data = DateTime.Parse(data.Text);

            a.Inserir(x);
            lista.ItemsSource = a.Listar();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object u = lista.SelectedItem;
            compromisso o = u as compromisso;
            a.Excluir(o);
            lista.ItemsSource = a.Listar();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           lista.ItemsSource =  a.Pesquisar(int.Parse(mes.Text), int.Parse(ano.Text));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"{ a.Qtd}", "Quantidade de compromissos");
        }
    }
}
