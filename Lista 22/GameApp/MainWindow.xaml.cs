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
using Mod;
using Neg;

namespace GameApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button_Click_1(null, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game m = new Game();
            m.SetID(int.Parse(id.Text));
            m.SetNome(nome.Text);
            m.SetFab(fab.Text);
            m.SetData(DateTime.Parse(datacompra.Text));
            m.SetEstrelas(int.Parse(estrela.Text));

            NGame n = new NGame();
            n.Insert(m);

            Button_Click_1(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NGame n = new NGame();
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NGame n = new NGame();
            grid.ItemsSource = null;
            grid.ItemsSource = n.SelectData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Game m = new Game();
            m.SetID(int.Parse(id.Text));
            m.SetNome(nome.Text);
            m.SetFab(fab.Text);
            m.SetData(DateTime.Parse(datacompra.Text));
            m.SetEstrelas(int.Parse(estrela.Text));

            NGame n = new NGame();
            n.Update(m);

            Button_Click_1(sender, e);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Game m = new Game();
            m.SetID(int.Parse(id.Text));

            NGame n = new NGame();
            n.Delete(m);

            Button_Click_1(sender, e);
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                Game g = grid.SelectedItem as Game;
                id.Text = g.GetID().ToString();
                nome.Text = g.GetNome();
                fab.Text = g.GetFab();
                datacompra.Text = g.GetData().ToString("dd/MM/yyyy");
                estrela.Text = g.GetEstrelas().ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NGame n = new NGame();
            top10.ItemsSource = null;
            top10.ItemsSource = n.Top10();
        }
    }
}
