using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._05
{
    class aluno : IComparable
    {
        public string nome { get; set; }
        public string matricula { get; set; }

        public int CompareTo(object obj)
        {
            aluno outro = obj as aluno;
            return nome.CompareTo(outro.nome);
        }
    }
}
