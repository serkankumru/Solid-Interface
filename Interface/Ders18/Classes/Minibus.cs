using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class Minibus : BaseTasit, ITasit
    {
        public Minibus()
        {
            Kapasite = 20;
            Hiz = 100;
        }

        public string IsminiSoyle()
        {
            return "Minibüs";
        }
    }
}
