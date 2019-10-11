using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._04
{
    class construtora
    {
        private List<funcionario> funcs = new List<funcionario>();

        public void Inserir(funcionario f)
        {
            funcs.Add(f);
        }

        public List<funcionario> funcionario()
        {
            return funcs;
        }

        public List<engenheiro> engenheiro()
        {
            List<engenheiro> eng = new List<engenheiro>();

            foreach (funcionario f in funcs)
                if (f is engenheiro) eng.Add(f as engenheiro);

            return eng;
        }

        public List<motorista> motorista()
        {
            List<motorista> mot = new List<motorista>();

            foreach (funcionario f in funcs)
                if (f is motorista) mot.Add(f as motorista);

            return mot;
        }
    }
}
