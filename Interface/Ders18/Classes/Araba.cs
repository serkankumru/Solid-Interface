using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class Araba : BaseTasit, ITasit
    {
        public Araba()
        {
            Kapasite = 5;
            Hiz = 120;
        }

        public string IsminiSoyle()
        {
            return "Araba";
        }
    }
}
