using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGame
{
    public class NGame
    {
        private List<Game> v = new List<Game>();
        private PGame p;

        public List<Game> Select()
        {
            return v.OrderBy(games => games.Nome);
        }
    }
}
