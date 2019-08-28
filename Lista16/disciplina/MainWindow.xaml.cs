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

namespace disciplina
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
            Historico h = new Historico(aluno.Text);
            h.Inserir(new Disciplina(disc.Text, sem.Text, int.Parse(media.Text)));
            // h.Inserir(new Disciplina("Design", 70));
            // h.Inserir(new Disciplina("Física", 95));
            list.ItemsSource = h.Listar(); // h.discs;
            txt.Text = h.IRA().ToString();

            // Aprovação
            bool ba;
            if (check1.IsChecked == true) ba = true;
            else ba = false;

        }

        class Disciplina
        {
            private string nome, semestre;
            private int media;
            private bool aprovado;

            public Disciplina(string nome, string sem, int media)
            {
                this.nome = nome;
                this.media = media;
                semestre = sem;
            }

            public override string ToString()
            {
                return $"{nome} - {semestre}";   
            }

            public int GetMedia()
            {
                return media;
            }
        }

        class Historico
        {
            private string aluno;
            private Disciplina[] discs = new Disciplina[10];
            private int k;

            public Historico(string aluno)
            {
                this.aluno = aluno;
            }

            public void Inserir(Disciplina d)
            {
                if (k < 10) discs[k++] = d;
            }

            public Disciplina[] Listar()
            {
                Disciplina[] novo = new Disciplina[k];
                Array.Copy(discs, novo, k);
                return novo;
            }

            public double IRA()
            {
                if (k == 0) return 0;
                double x = 0;
                foreach (Disciplina d in discs)
                    if (d != null) x = x + d.GetMedia();
                return x / k;
            }
        }

    }
}
