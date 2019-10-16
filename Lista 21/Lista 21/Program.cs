using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            try
            {
                t.SetTeste(int.Parse(Console.ReadLine()));
                Console.WriteLine(t.GetTeste());
                Console.ReadKey();
            }
            catch (Erro c)
            {
                Console.WriteLine("Valor negativo");
                Console.ReadKey();
            }
        }
    }
}
