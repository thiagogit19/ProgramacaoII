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
using System.Windows.Shapes;

namespace Ex._08___wpf
{
    /// <summary>
    /// Lógica interna para ProdutoWindow.xaml
    /// </summary>
    public partial class ProdutoWindow : Window
    {
        public ProdutoWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        internal produto GetProduto()
        {
            produto p = new produto(txtDesc.Text, decimal.Parse(txtPreco.Text), int.Parse(txtQtd.Text), DateTime.Parse(txtValidade.Text));
            return p;
        }
    }
}
