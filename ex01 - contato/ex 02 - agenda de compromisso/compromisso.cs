using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02___agenda_de_compromisso
{
    class compromisso
    {
        private string assunto;
        private string local;
        private DateTime data;

        public string Assunto {
            get { return assunto;  }
            set { assunto = value;  }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public DateTime Data {
            get { return data;  }
            set { data = value;  }
        }

        public override string ToString()
        {
            return $"{assunto} - {local} - {data}";
        }
    }
}
