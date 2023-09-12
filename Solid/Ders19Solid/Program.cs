using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            IdbContext db = new dbContext();
            db.Add();
            IdbContext db1 = new dbContext1();
            db1.Add();


            UserRepository u = new UserRepository(db);
            CustomerRepository c = new CustomerRepository(db1);

            foreach (var item in u.List())
            {
                Console.WriteLine(item);
            }


            foreach (var item in c.List())
            {
                Console.WriteLine(item);
            }




            //MattOperationFactory mo = new MattOperationFactory();

            //IMathOp mathOp = mo.CreateMethot();
            //int a = 5;
            //int b = 8;

            ////Console.WriteLine(mathOp.kare(a));
            //Console.WriteLine(mathOp.cikar(a,b));
            //Console.WriteLine(mathOp.topla(a,b));


            //Insan i = new Insan() { Name = "Serkan", Surname = "Kumru", BirtDate = Convert.ToDateTime("05.09.1997") };
            //Console.WriteLine(i.HowAreYou());

            Console.Read();
        }
    }
}
