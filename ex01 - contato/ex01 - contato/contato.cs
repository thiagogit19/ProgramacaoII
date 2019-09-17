using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01___contato
{
    class contato
    {
        private string nome, email;
        private DateTime nascimento;

        public string Nome{
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        public int Idade
        {
            get { return DateTime.Now.Year - nascimento.Year;  }
        }

        public override string ToString()
        {
            return $"{nome} - {email} - {nascimento} - {Idade}";
        }
    }
}
