using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Mod;


namespace Persistencia
{
    public class PGame
    {
        private string arquivo = "arquivo.xml";

        public List<Game> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Game>));
            StreamReader f = null;
            List<Game> list = null;

            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                list = x.Deserialize(f) as List<Game>;
            }
            catch
            {
                list = new List<Game>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return list;
        }

        public void Save(List<Game> g)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Game>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, g);
            f.Close();
        }
    }
}
