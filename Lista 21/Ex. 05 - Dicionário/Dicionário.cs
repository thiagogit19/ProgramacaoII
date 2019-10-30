using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._05___Dicionário
{
    class Dicionário <K, V>
    {
        private List<K> chaves = new List<K>();
        private List<V> valores = new List<V>();

        public List<K> Chaves { get => chaves; }

        public List<V> Valores { get => valores; }

        public int Count { get => valores.Count; }

        public V this[K chave]
        {
            get
            {
                int p = chaves.IndexOf(chave);
                if (p == -1)
                    throw new InvalidOperationException();
                else return valores[p];
            }

            set
            {
                if (chaves.Contains(chave))
                {
                    valores[chaves.IndexOf(chave)] = value;
                }

                else
                {
                    chaves.Add(chave);
                    valores.Add(value);
                }
            }
        }

        public void Add(K chave, V valor)
        {
            if (valor == null) throw new ArgumentNullException();
            if (chaves.Contains(chave)) throw new InvalidOperationException();

            else
            {
                valores.Add(valor);
                chaves.Add(chave);
            }
        }

        public void Clear()
        {
            valores.Clear();
            chaves.Clear();
        }

        public bool Contains(K chave)
        {
            if (chaves.Contains(chave)) return true;
            else return false;
        }

        public bool Remove(K chave)
        {
            if (chaves.Contains(chave)) return chaves.Remove(chave);
            else return false;
        }
    }
}
