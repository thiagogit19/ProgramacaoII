using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04___aplicativo
{
    interface IComparable
    {
        int CompareTo();
        void Curtir();
        // string Nome;
        // int Curtidas;
        string ToString();
        string GetCategoria();
    }
}
