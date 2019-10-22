using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._04___Jogo
{
    class Jogador : IComparable
    {
        private string nome, email;
        private int PontuacaoMaxima;
        private DateTime data;

        public Jogador(string n, string e)
        {
            nome = n;
            email = e;
        }

        public string Nome { get => nome; }

        public DateTime Data { get => data; }

        public int Pontuacao { get => PontuacaoMaxima; }

        public string Email()
        {
            return email;
        }

        public void SetPontos(int p, DateTime d)
        {
            if (p > 0) PontuacaoMaxima = p;
            else throw new ArgumentOutOfRangeException();
            if (d <= DateTime.Now) data = d;
            else throw new ArgumentOutOfRangeException();
        }

        public override string ToString()
        {
            return $"{nome} - {email} - {PontuacaoMaxima} - {data}";
        }

        public int CompareTo(object obj)
        {
            Jogador outro = obj as Jogador;
            if (PontuacaoMaxima.CompareTo(outro.PontuacaoMaxima) != 0)
                return - PontuacaoMaxima.CompareTo(outro.PontuacaoMaxima);
            else return Data.CompareTo(outro.Data);
        }
    }
}
