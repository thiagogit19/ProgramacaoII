using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._021
{
    class FreteExpresso : frete
    {
        private decimal seguro;

        public FreteExpresso(double d, double p, decimal s) : base(d, p)
        {
            seguro = s;
        }

        public override decimal CalcFrete()
        {
            //decimal x = (decimal) (0.01);
            return (decimal)(2 * base.CalcFrete() + 0.01m * seguro);
        }
    }
}
