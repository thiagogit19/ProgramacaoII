using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista17
{
    class anual
    {
        private string nome;
        private int nota1, nota2, nota3, nota4, notaf;

        public anual(string n, int n1, int n2, int n3, int n4, int nf)
        {
            nome = n;
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
            nota4 = n4;
            notaf = nf;
        }

        public override string ToString()
        {
            return $"{nome} - {nota1} - {nota2} - {nota3} - {nota4} - {notaf}";
        }

        public int GetMedia()
        {
            int m = (2 * nota1 + 2 * nota2 + 3 * nota3 + 3 * nota4) / 10;
            if (m < 60) m += notaf;
            return m;
        }

    }
}
