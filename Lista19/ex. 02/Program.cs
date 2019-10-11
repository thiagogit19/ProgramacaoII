using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            string fone = Console.ReadLine();
            contato c = new contato(nome, fone);
            string descricao = Console.ReadLine();
            grupo g = new grupo(descricao);
            Console.WriteLine(c);
            Console.WriteLine(g);
        }
    }
}
