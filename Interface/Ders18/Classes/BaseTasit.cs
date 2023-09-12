using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class BaseTasit
    {
        public int Hiz { get; set; }

        public int Kapasite { get; set; }

        public double KacSaat(double yol)
        {
            return yol / Hiz;
        }
    }
}
