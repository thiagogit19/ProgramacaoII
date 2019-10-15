using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._02
{
    class Pilha1<T>
    {
        List<T> lista = new List<T>();

        public int Count()
        {
            return lista.Count;
        }

        public T Top()
        {
            return lista[0];
        }

        public void Pop(T obj)
        {
           lista.Remove(obj);
        }

        public void Push(T obj)
        {
            lista.Add(obj);
        }
    }
}
