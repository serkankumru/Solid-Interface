using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class TasitCommander
    {
        public double DoWork(ITasit tasit,double yol)
        {
            Console.WriteLine(tasit.IsminiSoyle());
            return tasit.KacSaat(yol);
        }
    }
}
