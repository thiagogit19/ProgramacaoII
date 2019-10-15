using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._05
{
    class curso
    {
        private string descricao;
        private List<turma> turmas = new List<turma>();

        public curso(string d)
        {
            descricao = d;
        }

        public void InserirTurma(turma t)
        {
            turmas.Add(t);
        }

        public turma[] ListarTurma()
        {
            turma[] vetor = new turma[turmas.Count];
            int y = 0;

            foreach (turma t in turmas)
            {
                vetor[y++] = t;
            }

            Array.Sort(vetor);
            return vetor;
        }
    }
}
