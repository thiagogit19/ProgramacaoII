﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05___livraria
{
    class TituloComp : IComparer
    {
        public int Compare(object x, object y)
        {
            Livro a = x as Livro;
            Livro b = y as Livro;
            return a.Titulo.CompareTo(b.Titulo);
        }
    }
}
