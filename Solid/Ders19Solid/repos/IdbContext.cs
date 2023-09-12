using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19Solid
{
    public interface IdbContext
    {
        List<string> Listele();
        void Add();
    }
}
