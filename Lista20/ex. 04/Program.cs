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
            agenda a = new agenda();
            for (int i = 0; i < 5; i++)
            {
                contato c = new contato();
                c.nome = Console.ReadLine();
                c.email = Console.ReadLine();
                c.fone = Console.ReadLine();
                a.Inserir(c);
            }
            foreach (contato c in a.Listar()) Console.WriteLine(c);
            Console.WriteLine();
            foreach (contato c in a.Pesquisar(Console.ReadLine())) Console.WriteLine(c); 
            Console.ReadKey();
        }
    }
}
