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

namespace retangulo
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
            retangulo r = new retangulo();
            r.SetBase(double.Parse(b.Text));
            r.SetAltura(double.Parse(h.Text));
            area.Text = r.CalcArea().ToString();
            d.Text = r.CalcDiagonal().ToString();
        }

        class retangulo
        {
            private double high, basis;

            public void SetBase(double b)
            {
                basis = b;
            }

            public double GetBase()
            {
                return basis;
            }

            public void SetAltura(double h)
            {
                high = h;
            }
            
            public double GetAltura()
            {
                return high;
            }

            public double CalcArea()
            {
                return high * basis;
            }

            public double CalcDiagonal()
            {
                double x;
                x = Math.Pow(high, 2) + Math.Pow(basis, 2);
                return Math.Sqrt(x);
            }

        }
    }
}
