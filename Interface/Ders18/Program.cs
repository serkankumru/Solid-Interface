using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    class Program
    {
        static void Main(string[] args)
        {
            HesaplaCommanderWithGeneric();
            //HesaplaCommander();
            //HesaplaInteface();
            //Hesapla();
            Console.Read();
        }

        private static void HesaplaCommanderWithGeneric()
        {
            Console.WriteLine("Kaç kişi ");
            int Capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç KM ");
            int Yol = Convert.ToInt32(Console.ReadLine());

            //TasitCommanderWithGeneric<ITasit> arb = new TasitCommanderWithGeneric<ITasit>();
            Console.WriteLine(new TasitCommanderWithGeneric<ITasit>().DoWork(new TasitFactory().TasitCreator(Capacity),Yol));
        }

        private static void HesaplaCommander()
        {
            Console.WriteLine("Kaç kişi ");
            int Capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç KM ");
            int Yol = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new TasitCommander().DoWork(new TasitFactory().TasitCreator(Capacity), Yol));
        }

        private static void HesaplaInteface()
        {
            Console.WriteLine("Kaç kişi ");
            int Capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç KM ");
            int Yol = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new TasitFactory().TasitCreator(Capacity).KacSaat(Yol));
        }

        public static void Hesapla()
        {
            int Capacity = Convert.ToInt32(Console.ReadLine());
            int yol = Convert.ToInt32(Console.ReadLine());

            //TasitFactory t = new TasitFactory();
            //Console.Write(t.TasitCreator(Capacity).GetType());

            if (Capacity == 1)
            {
                Console.Write(new Bisiklet().KacSaat(yol));
            }
            else if (Capacity > 1 && Capacity <= 5)
            {
                Console.Write(new Araba().KacSaat(yol));
            }
            else if (Capacity >= 6 && Capacity <= 20)
            {
                Console.Write(new Minibus().KacSaat(yol));
            }
            else if (Capacity >= 21 && Capacity <= 100)
            {
                Console.Write(new Otobus().KacSaat(yol));
            }
        }
    }
}
