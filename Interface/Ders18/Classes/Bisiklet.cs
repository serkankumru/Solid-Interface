using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class Bisiklet : BaseTasit, ITasit
    {
        public Bisiklet()
        {
            Kapasite = 1;
            Hiz = 20;
        }

        public string IsminiSoyle()
        {
            return "Bisiklet";
        }
    }
}
