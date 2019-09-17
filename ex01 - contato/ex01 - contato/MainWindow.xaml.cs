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

namespace ex01___contato
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

        contato x;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            x = new contato();
            x.Nome = nome.Text;
            x.Email = email.Text;
            x.Nascimento = DateTime.Parse(nascimento.Text);
            lista.Items.Add(x.ToString());
        }


    }
}
