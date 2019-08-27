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
            historico h = new historico("Thiago");
            disciplina[] x = new disciplina[10];
            h.Inserir( new disciplina("PEOO") );
            h.Inserir( new disciplina("Design") );
            h.Inserir( new disciplina("Física") ); 

            list.ItemsSource = h.Listar();
        }
        class disciplina
        {
            private string nome;
            public disciplina(string nome)
            {
                this.nome = nome;
            }
            public override string ToString()
            {
                return nome;
            }
        }

        class historico
        {
            private string aluno;
            private disciplina[] discs = new disciplina[10];
            private int k;

            public historico(string aluno)
            {
                this.aluno = aluno;
            }

            public void Inserir(disciplina d)
            {
                if (k < 10) discs[k++] = d; 
            }

            public disciplina[] Listar()
            {
                disciplina[] novo = new disciplina[k];
                Array.Copy(discs, novo, k);
                return novo;
            }

            public double IRA()
            {
                if (k == 0) return 0;
                double x = 0;
                foreach (disciplina x in discs)
                {   
                    if (dx != )
                    x = x + SByte.GetMedia();
                }
                return x / k;
            }
        }

    }
}
