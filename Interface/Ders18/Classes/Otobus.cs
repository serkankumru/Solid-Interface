using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class Otobus : BaseTasit, ITasit
    {
        public Otobus()
        {
            Kapasite = 100;
            Hiz = 80;
        }

        public string IsminiSoyle()
        {
            return "Otobüs";
        }
    }
}
