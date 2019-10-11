using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._02
{
    class contato
    {
        private string nome, fone;

        public contato(string n, string f)
        {
            nome = n;
            fone = f;
        }

        public override string ToString()
        {
            return $"{nome} - {fone}";
        }
    }
}
