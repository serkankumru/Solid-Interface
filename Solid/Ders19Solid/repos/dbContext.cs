using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19Solid
{
    public class dbContext : IdbContext
    {
        List<string> s = new List<string>();
        
        public List<string> Listele()
        {
            return s;
        }

        public void Add()
        {
            s.Add("aaa");
            s.Add("bbb");
            s.Add("ccc");
        }
    }

    public class dbContext1 : IdbContext
    {
        List<string> s1 = new List<string>();

        public List<string> Listele()
        {
            return s1;
        }

        public void Add()
        {
            s1.Add("xxx");
            s1.Add("yyy");
            s1.Add("zzz");
        }
    }
}
