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

namespace sequencia
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

        Fibonacci x;
        PA y;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lista1.Items.Clear();
            lista.Items.Clear();
            x = new Fibonacci();
            y = new PA(int.Parse(a1.Text), int.Parse(r.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lista1.Items.Add(x.Proximo());
            lista.Items.Add(y.Proximo());

        }
    }


}
