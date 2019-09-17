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

        agenda t = new agenda();
        compromisso x;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            x = new compromisso();
            x.Assunto = assunto.Text;
            x.Local = local.Text;
            x.Data = DateTime.Parse(data.Text);
            lista.Items.Add(x.ToString());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(lista.SelectedIndex != -1)
            {
                t.Excluir(lista.SelectedIndex);
                lista.ItemsSource = null;
                lista.Items.Add(t.Excluir());
            }
        }
    }
}
