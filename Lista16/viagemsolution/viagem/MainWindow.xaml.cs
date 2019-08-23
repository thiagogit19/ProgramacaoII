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

namespace viagem
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
            Viagem x = new Viagem();
            x.SetDistancia(double.Parse(ds.Text));
            x.SetTempo(double.Parse(dt.Text));
            vm.Text = x.CalcVelocidade().ToString();


        }

        class Viagem
        {
            private double distancia, tempo;

            public void SetDistancia(double d)
            {
                distancia = d;
            }

            public double GetDistancia()
            {
                return distancia;
            }

            public void SetTempo(double t)
            {
                tempo = t;
            }

            public double GetTempo()
            {
                return tempo;
            }

            public double CalcVelocidade()
            {
                return distancia / tempo;
            }
        }
    }
}
