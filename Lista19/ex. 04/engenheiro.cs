using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._04
{
    class engenheiro : funcionario
    {
        private string crea;

        public void SetCrea(string c)
        {
            crea = c;
        }

        public string GetCrea()
        {
            return crea;
        }

        public override string ToString()
        {
            return $"{GetNome()} - {GetFone()} - {GetEmail()} - {crea}";
        }
    }
}
