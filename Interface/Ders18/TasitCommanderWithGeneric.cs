using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class TasitCommanderWithGeneric<T> where T:ITasit
    {
        public double DoWork(T tasit, int yol)
        {
            Console.WriteLine(tasit.IsminiSoyle());
            return tasit.KacSaat(yol);
        }
    }
}
