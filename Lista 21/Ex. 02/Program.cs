using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Retangulo r = new Retangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine(r.CalcArea());
            }

            catch (ArgumentOutOfRangeException x)
            {
                Console.WriteLine("Valor negativo.");
            }
            Console.ReadKey();
        }
    }
}
