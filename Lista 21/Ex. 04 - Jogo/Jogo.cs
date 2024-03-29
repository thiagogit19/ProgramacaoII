﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._04___Jogo
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
            jogs.Sort();
            return jogs[0];
        }

        public List<Jogador> Top10()
        {
            List<Jogador> novo = new List<Jogador>();
            jogs.Sort();

            for (int i = 0; i < 10; i++)
                if (i == jogs.Count) break;
                else novo.Add(jogs[i]);
            return novo;

            // return jogs.Take<Jogador>(10).ToList();
        }
    }
}
