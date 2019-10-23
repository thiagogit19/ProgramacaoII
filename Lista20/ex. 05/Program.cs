using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._05
{
    class Program
    {
        static void Main(string[] args)
        {
            curso c = new curso("infoweb");
            turma t = new turma("PEOO", "1");
            c.InserirTurma(t);
            turma t1 = new turma("Banco de dados", "1");
            c.InserirTurma(t1);
            foreach (turma x in c.ListarTurma()) Console.WriteLine(x);
            aluno a = new aluno();
            a.nome = "Thiago";
            a.matricula = "2018011110017";
            t.InserirAluno(a);
            aluno a1 = new aluno();
            a1.nome = "Paulo";
            a1.matricula = "2018011110007";
            t.InserirAluno(a1);
            foreach (aluno x in t.ListarAlunos()) Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
