using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._04
{
    class Program
    {
        static void Main(string[] args)
        {
            construtora c = new construtora();
            engenheiro e = new engenheiro();
            e.SetNome("Thiago");
            e.SetEmail("thiago@");
            e.SetFone("(84) 9 8729-9203");
            e.SetCrea("12345");
            c.Inserir(e);

            motorista m = new motorista();
            m.SetNome("Gilbert");
            m.SetEmail("gilbert@");
            m.SetFone("(84) 9 4002-8922");
            m.SetCnh("54321");
            c.Inserir(m);

            foreach (funcionario f in c.funcionario()) Console.WriteLine(f);
            Console.WriteLine();
            foreach (funcionario f in c.motorista()) Console.WriteLine(f);
            Console.WriteLine();
            foreach (funcionario f in c.engenheiro()) Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
