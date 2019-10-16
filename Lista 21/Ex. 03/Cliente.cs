using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._03
{
    class Cliente
    {
        private string nome, email, fone;
        private List<Conta_Bancaria> contas = new List<Conta_Bancaria>();

        public Cliente(string n, string e, string f)
        {
            nome = n;
            email = e;
            fone = f;
        }

        public string Nome { get => nome; }

        public string Email { get => email; }

        public string Fone { get => fone; }

        public void Inserir(Conta_Bancaria c)
        {
            contas.Add(c);
        }

        public List<Conta_Bancaria> Listar()
        {
            return contas;
        }
    }
}
