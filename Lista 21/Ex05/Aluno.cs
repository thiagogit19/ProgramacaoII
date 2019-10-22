using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public override string ToString()
        {
            return $"{Nome} {Matricula}";
        }
    }
}
