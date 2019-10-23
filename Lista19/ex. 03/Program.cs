using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string num = Console.ReadLine();
            ContaCorrente cc = new ContaCorrente(t, num);
            double l = double.Parse(Console.ReadLine());
            ContaEspecial ce = new ContaEspecial(t, num, l);
            Poupanca p = new Poupanca(t, num);
            Console.WriteLine(cc);
            Console.WriteLine(ce);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
