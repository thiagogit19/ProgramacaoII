using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ex._04
{
    class agenda
    {
        private List<contato> cs = new List<contato>();
        private string arquivo = "arquivo.xml";

        public void Inserir(contato c)
        {
            cs.Add(c);
        }

        public List<contato> Listar()
        {
            return cs;
        }

        public List<contato> Pesquisar(string inicio)
        {
            List<contato> novo = new List<contato>();

            foreach (contato c in cs)
            {
                if (c.nome == inicio) novo.Add(c);
            }

            return novo;
        }

        public void Abrir()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<contato>));
            StreamReader f = new StreamReader(arquivo, Encoding.Default);
            x.Deserialize(f);
            f.Close();
        }

        public void Salvar()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<contato>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
