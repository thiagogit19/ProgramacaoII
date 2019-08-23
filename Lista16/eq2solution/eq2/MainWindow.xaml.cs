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

namespace eq2
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
            equacao t = new equacao();
            t.SetABC(double.Parse(a.Text), double.Parse((b.Text)), double.Parse((c.Text)));
            d.Text = t.CalcDelta().ToString();
            double r, s;
            if (t.CalcX1(out r))
            {
                t.CalcX2(out s);
                x1.Text = r.ToString();
                x2.Text = s.ToString();
            }
            else
            {
                x1.Text = "Raiz Complexa";
                x2.Text = "Raiz Complexa";
                MessageBox.Show("A equação não é do II grau ou não tem raízes reais");
            }


        }

        class equacao
        {
            private double a, b, c;

            public void SetABC(double x, double y, double z)
            {
                a = x;
                b = y;
                c = z;
            }

            public void GetABC(out double x, out double y, out double z)
            {
                x = a;
                y = b;
                z = c;
            }

            public double CalcDelta()
            {
                return b * b - 4 * a * c;
            }

            public bool RaizesReais()
            {
                if (CalcDelta() >= 0) return true;
                else return false;
            }

            public bool CalcX1(out double x)
            {
                x = 0;
                if (RaizesReais() == false || a == 0) return false;
                x = (-b + Math.Sqrt(CalcDelta())) / (2 * a);
                return true;
            }

            public bool CalcX2(out double x)
            {
                x = 0;
                if (RaizesReais() == false || a == 0) return false;
                x = (-b + Math.Sqrt(CalcDelta())) / (2 * a);
                return true;
            }
        }
    }
}
