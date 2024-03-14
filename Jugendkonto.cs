using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugendkonto_check
{
    public class Jugendkonto : Konto
    {
        public Jugendkonto()
        {

        }

        public double Limit { get; private set; }


        public double GetLimit()
        {
            return Limit;
        }
    }
}
