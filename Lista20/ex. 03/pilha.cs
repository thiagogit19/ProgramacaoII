using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._03
{
    class pilha<T>
    {
        private Queue<T> q1 = new Queue<T>();
        private Queue<T> q2 = new Queue<T>();

        public int Count()
        {
            if (q1.Count > 0) return q1.Count; // se tiver o número de elementos != 0 
            return q2.Count; 
        }

        public T Top()
        {
            while (Count() > 1)
            {
                q2.Enqueue(q1.Dequeue()); // INSERE O ELEMENTO INICIAL DA Q1 NO FINAL DA Q2
            }
   
            T k = q1.Peek(); // retorna o obj no início da pilha
            q1.Enqueue(q2.Dequeue()); // INSERE O ELEMENTO INICIAL DA Q2 NO FINAL DA Q1
            return k; 
        }

        public T Pop()
        {
            while (Count() > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            T k = q1.Peek();
            q1.Enqueue(q2.Dequeue());
            return k;
        }

        public void Push(T obj)
        {
            q1.Enqueue(obj);
        }
    }
}
