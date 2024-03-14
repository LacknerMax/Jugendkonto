using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugendkonto_check
{
    public class Konto
    {
        public double limit { get; private set; }

        public double Kontostand { get; private set; }


        public double GetLimit()
        {
            return limit;
        }

        public double GetKontostand() 
        { 
            return Kontostand;
        }
    }
}
