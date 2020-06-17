using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        class A
        {
            public virtual int Calc() => 10 * Gen();
            protected int Gen() => 10;
        }

        class B : A
        {
            public override int Calc() => 20 * Gen();
            protected int Gen() => 20;
        }

        class C : B
        {
            public override int Calc() => 30 * Gen();
            protected int Gen() => base.Gen();
        }

        static void Main(string[] args)
        {
            A a = new B();
            A a1 = new C();
            Console.WriteLine(a.Calc() + a1.Calc());

            Console.ReadKey();
        }
    }
}
