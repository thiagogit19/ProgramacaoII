using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._06
{
    class Program
    {
        static void Main(string[] args)
        {
            empresa e = new empresa();
            cliente c = new cliente("Thiago", "70231", 3000m);
            cliente c1 = new cliente("Gilbert", "70451", 2500m);
            e.Inserir(c);
            e.Inserir(c1);
            foreach (cliente x in e.ListarNome()) Console.WriteLine(x);
            Console.WriteLine();
            foreach (cliente x in e.ListarLimite()) Console.WriteLine(x);

            Console.WriteLine();
            foreach (cliente x in e.ListarNaoSocio()) Console.WriteLine(x);

        }
    }
}
