using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class TasitFactory
    {
        public ITasit TasitCreator(int x)
        {
            if (x == 1)
            {
                return new Bisiklet();
            }
            else if (x > 1 && x <= 5)
            {
                return new Araba();
            }
            else if (x >= 6 && x <= 20)
            {
                return new Minibus();
            }
            else if (x >= 21 && x <= 100)
            {
                return new Otobus();
            }
            else
            {
                throw new Exception("bilinmeyen araç tipi");
            }
        }
    }
}
