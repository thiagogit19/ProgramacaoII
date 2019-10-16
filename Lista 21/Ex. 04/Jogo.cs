using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._04
{
    class Jogo
    {
        private string nome;
        private List<Jogador> jogs = new List<Jogador>();

        public Jogo(string n)
        {
            nome = n;
        }

        public void Inserir(Jogador j)
        {
            foreach (Jogador c in jogs)
            {
                if (c.Email() == j.Email()) throw new EmailExistenteException();
            }
            jogs.Add(j);
        }

        public List<Jogador> Listar()
        {
            return jogs;
        }

        public Jogador Top1()
        {
            foreach(Jogador j in jogs)
            {
                if (j.Pontuacao >  )
            }
        }

        public List<Jogador> Top10()
        {

        }


    }
}
