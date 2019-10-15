using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._05
{
    class turma : IComparable
    {
        private string disciplina, semestre;
        private List<aluno> alunos = new List<aluno>();
        private int num;

        public int NumAluno
        {
            get { return num; }
            set { num = value; }
        }

        public turma(string s, string d)
        {
            semestre = s;
            disciplina = d;
        }

        public void InserirAluno(aluno a)
        {
            alunos.Add(a);
        }

        public aluno[] ListarAlunos()
        {
            aluno[] novo = new aluno[alunos.Count];
            int y = 0;

            foreach (aluno a in alunos)
            {
                novo[y++] = a;
            }
            Array.Sort(novo);
            return novo;
        }

        public int CompareTo(object obj)
        {
            turma outro = obj as turma;
            if (this.semestre != outro.semestre) return this.semestre.CompareTo(outro.semestre);
            else return this.disciplina.CompareTo(outro.disciplina);
        }
    }

}
