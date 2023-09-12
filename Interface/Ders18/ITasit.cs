using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public interface ITasit
    {
        int Kapasite { get; set; }
        int Hiz { get; set; }
        double KacSaat(double yol);
        string IsminiSoyle();
    }
}
