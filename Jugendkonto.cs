using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Jugendkonto_check
{
    public class Jugendkonto : Konto
    {

        private double _Limit;
        private double _kontostand;



        
        public double GetLimit(double Limit)
        {
            return _Limit;

            
        }
        public double GeldAbheben(double kontostand)
        {
            return kontostand;
        }

        public double GetKontostand(double kontostand)
        {
            return Kontostand;

            if(GeldAbheben > Limit)
            {
                Console.WriteLine("Ihr gewünschter Betrag übersteigt das Limit");
            }
            
        }

        

        
        
    }

}
