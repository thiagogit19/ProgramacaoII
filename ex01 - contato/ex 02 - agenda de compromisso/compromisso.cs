using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02___agenda_de_compromisso
{
    class compromisso
    {
        public string Assunto { get; set; }

        public string Local { get; set; }

        public DateTime Data { get; set; }

        public override string ToString()
        {
            return $"{Assunto} - {Local} - {Data}";
        }
    }
}
