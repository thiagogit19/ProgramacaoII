using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._01
{
    class quadrado : retangulo
    {
        public quadrado(double l) : base(l, l) { }

        public override string ToString()
        {
            return $"{base.GetBase()} - {CalcArea()} - {CalcDiagonal()}";
        }
    }
}
