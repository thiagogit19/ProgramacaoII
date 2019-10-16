using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cliente c = new Cliente(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                Conta_Bancaria cb;
                Console.WriteLine();
                cb = new Conta_Bancaria(Console.ReadLine(), decimal.Parse(Console.ReadLine()));
                cb.Depositar(decimal.Parse(Console.ReadLine()));
                Console.WriteLine(cb.Saldo());
                cb.Sacar(decimal.Parse(Console.ReadLine()));
                Console.WriteLine(cb.Saldo());
                c.Inserir(cb);
                Console.WriteLine();
                cb = new Conta_Bancaria(Console.ReadLine(), decimal.Parse(Console.ReadLine()));
                cb.Depositar(decimal.Parse(Console.ReadLine()));
                Console.WriteLine(cb.Saldo());
                cb.Sacar(decimal.Parse(Console.ReadLine()));
                Console.WriteLine(cb.Saldo());
                c.Inserir(cb);
                Console.WriteLine();

                foreach (Conta_Bancaria z in c.Listar()) {
                    Console.WriteLine(z);
                }
            }

            catch (ArgumentOutOfRangeException x)
            {
                Console.WriteLine("Valor para saque | Depósito inválido");
            }
            
            catch (InversaoSaldoException z)
            {
                Console.WriteLine("Valor maior que o saldo.");
            }

            Console.ReadKey();
        }
    }
}
