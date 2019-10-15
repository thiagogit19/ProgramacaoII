using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01
{
    class conversor
    {
        private int num;
        private Stack<int> pilha = new Stack<int>();


        public void SetNum(int num)
        {
            this.num = num;
        }

        public string binario()
        {
            string s = "";
            while (num != 0)
            {
                pilha.Push(num % 2);
                num = num / 2;
            }

            while (pilha.Count > 0)
            {
                s += (pilha.Pop()).ToString();
            }
            return s;
        }
    }
}
