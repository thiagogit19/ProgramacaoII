using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._04
{
    class funcionario
    {
        private string nome, fone, email;

        public void SetNome(string n)
        {
            nome = n;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetFone(string n)
        {
            fone = n;
        }

        public string GetFone()
        {
            return fone;
        }

        public void SetEmail(string n)
        {
            email = n;
        }

        public string GetEmail()
        {
            return email;
        }

        public override string ToString()
        {
            return $"{nome} - {fone} - {email}";
        }
    }

}
