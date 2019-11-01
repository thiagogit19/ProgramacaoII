using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod;
using Persistencia;

namespace Neg
{
    public class NGame
    {
        private List<Game> v = new List<Game>();
        private PGame p;

        public void Insert(Game g)
        {
            v.Add(g);
        }

        public List<Game> Select()
        {
            p = new PGame();
            return p.Open().OrderBy(g => g.GetNome()).ToList();
        }

        public List<Game> SelectData()
        {
            p = new PGame();
            return p.Open().OrderBy(g => g.GetData()).ToList();
        }

        public List<Game> Top10()
        {
            List<Game> novo = new List<Game>();
            v.Sort();

            for (int i = 0; i < 10; i++)
                if (i == v.Count) break;
                else novo.Add(v[i]);
            return novo;
        }

        public void Update(Game g)
        {
            p = new PGame();
            List<Game> up = p.Open();
            for (int i = 0; i < up.Count; i++)
                if (up[i].GetID() == g.GetID())
                {
                    up.RemoveAt(i);
                    break;
                }
            up.Add(g);
            p.Save(up);
        }

        public void Delete(Game g)
        {
            p = new PGame();
            List<Game> del = p.Open();
            for (int i = 0; i < del.Count; i++)
                if (del[i].GetID() == g.GetID())
                {
                    del.RemoveAt(i);
                    break;
                }
            p.Save(del);
        }
    }
}
