using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._01
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            retangulo r = new retangulo(b, h);
            quadrado q = new quadrado(b);
            Console.WriteLine(r);
            Console.WriteLine(q);
        }
    }
}
