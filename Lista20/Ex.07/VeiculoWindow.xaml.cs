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
using System.Windows.Shapes;

namespace Ex._07
{
    /// <summary>
    /// Lógica interna para VeiculoWindow.xaml
    /// </summary>
    public partial class VeiculoWindow : Window
    {
        public VeiculoWindow()
        {
            InitializeComponent();
        }

        veiculo v;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }


        internal veiculo GetVeiculo()
        {
            return v = new veiculo(placa.Text, fab.Text, mod1.Text, int.Parse(ano.Text), decimal.Parse(preco.Text));
        }

        
    }
}
