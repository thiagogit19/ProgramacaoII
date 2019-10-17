using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_21
{
    class Teste : ITeste
    {
        private int value;

        public void SetTeste(int valor)
        {
            if (valor < 0) throw new Erro();  
            else value = valor;
        }

        public int GetTeste()
        {
            return value;
        }
    }
}
