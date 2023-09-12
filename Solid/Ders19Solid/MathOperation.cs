using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19Solid
{
    public class MathOperation : IMathOp,IMathOpNew
    {
        public int kare(int a)
        {
            return a * a;
        }

        public int topla(int a, int b)
        {
            return a + b;
        }

        public int cikar(int a, int b)
        {
            return a - b;
        }
    }
    public class MattOperationFactory
    {
        public IMathOpNew CreateMethot()
        {
            return new MathOperation();
        }

    }

    public interface IMathOp
    {
        int topla(int a, int b);
        int cikar(int a, int b);
    }
    public interface IMathOpNew : IMathOp
    {
        int kare(int a);
    }
}
