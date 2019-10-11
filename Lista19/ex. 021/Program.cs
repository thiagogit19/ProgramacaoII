using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._021
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            frete f = new frete(d, p);
            decimal s = decimal.Parse(Console.ReadLine());
            FreteExpresso fretex = new FreteExpresso(d, p, s);
            Console.WriteLine(f);
            Console.WriteLine(fretex);
        }
    }
}
