using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod
{
    public class Game
    {
        private int Id, estrelas;
        private string nome, fab;
        private DateTime data;

        public void SetID(int id) { Id = id; }
        public int GetID() { return Id; }

        public void SetNome(string n) { nome = n; }
        public string GetNome() { return nome; }

        public void SetFab(string f) { fab = f; }
        public string GetFab() { return fab; }

        public void SetData(DateTime d) { data = d; }
        public DateTime GetData() { return data; }

        public void SetEstrelas(int e) { estrelas = e; }
        public int GetEstrelas() { return estrelas; }
    }
}
