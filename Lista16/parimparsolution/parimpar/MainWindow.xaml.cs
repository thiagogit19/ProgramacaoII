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

namespace parimpar
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
            numeros n = new numeros();
            n.SetInicio(int.Parse(a.Text));
            n.SetFim(int.Parse(b.Text));
            bool bp, bi;
            if (check1.IsChecked == true) bp = true;
            else bp = false;
            if (check2.IsChecked == true) bi = true;
            else bi = false;
            txtlist.ItemsSource = n.Calc(bp, bi);
        }

        class numeros {
            private int inicio, fim;

            public void SetInicio(int a)
            {
                inicio = a;
            }

            public int GetInicio()
            {
                return inicio;
            }

            public void SetFim(int a)
            {
                fim = a;
            }

            public int GetFim()
            {
                return fim;
            }
            
            public int[] Calc(bool p, bool i)
            {
                int[] z = new int[fim-inicio+1]; 
                int cont = 0;
                for (int x = inicio; x <= fim; x++)
                {
                    if (p == true && i == false && x % 2 == 0)
                    {
                        z[cont] = x;
                        cont++;
                    }

                    if (i == true && p == false && x % 2 != 0)
                    {
                        z[cont] = x;
                        cont++;
                    }

                    if (p == true && i == true)
                    {
                        z[cont] = x;
                        cont++;
                    }
                }
                int[] w = new int[cont];
                Array.Copy(z, w, cont);
                return w;
            }
        }
    }
}
