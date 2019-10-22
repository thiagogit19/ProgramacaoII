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

namespace Ex._05
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
            Dicionario<int, string> x = new Dicionario<int, string>();
            x.Add(1, "um");
            x.Add(2, "dois");
            x.Add(3, "três");
            listC.ItemsSource = null;
            listV.ItemsSource = null;
            listC.ItemsSource = x.Chaves;
            listV.ItemsSource = x.Valores;
            MessageBox.Show(x[2]);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dicionario<string, string> x = new Dicionario<string, string>();
            x.Add("one", "um");
            x.Add("two", "dois");
            x.Add("three", "três");
            listC.ItemsSource = null;
            listV.ItemsSource = null;
            listC.ItemsSource = x.Chaves;
            listV.ItemsSource = x.Valores;
            MessageBox.Show(x["two"]);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Aluno x = new Aluno { Nome = "Maria Luiza", Matricula = "1111-2222" };
            Aluno y = new Aluno { Nome = "Victor Medeiros", Matricula = "3333-4444" };
            Aluno z = new Aluno { Nome = "Victor Wagner", Matricula = "5555-6666" };
            Curso a = new Curso { Nome = "InfoWeb" };
            Curso b = new Curso { Nome = "Tads" };

            Dicionario<Aluno, Curso> d = new Dicionario<Aluno, Curso>();
            d.Add(x, a);
            d.Add(y, a);
            d.Add(z, b);
            listC.ItemsSource = null;
            listV.ItemsSource = null;
            listC.ItemsSource = d.Chaves;
            listV.ItemsSource = d.Valores;

            MessageBox.Show(d[z].ToString());
        }
    }
}
