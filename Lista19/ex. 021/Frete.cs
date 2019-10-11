using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._021
{
    class frete
    {
        private double distancia;
        private double peso;

        public frete(double d, double p)
        {
            distancia = d;
            peso = p;
        }

        public double GetDistancia()
        {
            return distancia;
        }

        public double GetPeso()
        {
            return peso;
        }

        public virtual decimal CalcFrete()
        {
            return (decimal)(0.01 * distancia * peso);
        }

        public override string ToString()
        {
            return $"{distancia} - {peso} - {CalcFrete()}";
        }
    }
}
