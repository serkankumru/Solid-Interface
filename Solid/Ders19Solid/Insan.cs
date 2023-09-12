using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19Solid
{
    public class Insan
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirtDate { get; set; }

        public string HowAreYou()
        {
            if (!BirtDate.HasValue)
            {
                return "Exc:BirtDate not defined for onject";
            }
            int age = DateTime.Now.Year - BirtDate.Value.Year;
            return Name + " " + Surname + " Age:" + age;
        }

        public int gun { get; set; }
        public virtual decimal UcretHesapla()
        {
            return 0;
        }

    }

    public class Ogrenci : Insan
    {
        public int OgrenciNo { get; set; }
        public override decimal UcretHesapla()
        {
            return gun * 50;
        }
    }

    public class Ogretmen : Insan
    {
        public int EgitmenNo { get; set; }
        public override decimal UcretHesapla()
        {
            return gun * 100;
        }
    }
}
