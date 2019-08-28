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
        Historico h;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // cria um novo aluno
        {
            h = new Historico(aluno.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // cria disciplina, semestre e media para aluno
        {   
            h.Inserir(new Disciplina(disc.Text, sem.Text, int.Parse(media.Text), check1.IsChecked.Value));
            list.ItemsSource = h.Listar(); // h.discs;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // mostra IRA do aluno
        {
            MessageBox.Show(h.IRA().ToString());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // exclui matéria de aluno
        {
            if (list.SelectedIndex != -1) // nenhum selecionado
                h.Excluir(list.SelectedIndex); // exclui o selecionado
            list.ItemsSource = h.Listar(); // depois lista novamente com o selecionado removido
        }
    }

    class Disciplina
    {
        private string nome, semestre;
        private int media;
        private string aprovado;

        public Disciplina(string nome, string sem, int media, bool a)
        {
            this.nome = nome;
            this.media = media;
            semestre = sem;

            if (a == true) aprovado = "Aprovado";
            else aprovado = "Reprovado";
        }

        public override string ToString() // impressão no listbox
        {
            return $"{nome} - {semestre} - {media} - {aprovado}";
        }

        public int GetMedia()
        {
            return media;
        }
    }

    class Historico
    {
        private string aluno;
        private Disciplina[] discs = new Disciplina[10]; // vetor de matérias
        private int k;

        public Historico(string aluno)
        {
            this.aluno = aluno;
        }

        public void Inserir(Disciplina d)
        {
            if (k < 10) discs[k++] = d; // ADICIONA SEMESTRE, DISCIPLINA E NOTA
        }

        public void Excluir(int x)
        {
            for (int i = x; i < k; i++) // x é o índice
            {
                discs[i] = discs[i + 1];
            }
            k--; // CONTADOR DE MATÉRIAS DIMINUIRIA UMA POSIÇÃO, DE MODO QUE NÃO HOUVESSE VAZIO
        }

        public Disciplina[] Listar() // LISTA AS DISCIPLINAS DO ALUNO
        {
            Disciplina[] novo = new Disciplina[k];
            Array.Copy(discs, novo, k); // TRANSFERE PARA UM NOVO VETOR AS DISCIPLINAS, SEM HAVER VAZIO
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

