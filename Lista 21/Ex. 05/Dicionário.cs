using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._05
{
    class Dicionario<K, V>
    {
        private List<K> chaves = new List<K>();
        private List<V> valores = new List<V>();
        public void Add(K chave, V valor)
        {
            chaves.Add(chave);
            valores.Add(valor);
        }
        public List<K> Chaves { get { return chaves; } }
        public List<V> Valores { get { return valores; } }
        public V this[K chave]
        {
            get
            {
                int p = chaves.IndexOf(chave);
                if (p == -1) return default(V);
                else return valores[p];
            }
        }
    }
}
