using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        public void Show()
        {
            A a = new A(), b = new B(), c = new C();
            I ia = new A(), ib = new B(), ic = new C();
            Console.WriteLine($"{a.P}, {b.P}, {c.P}, {ia.P}, {ib.P}, {ic.P}");
        }

        interface I
        {
            int P { get; }
        }

        class A : I
        {
            public virtual int P => 0;
        }

        class B : A
        {
            public override int P => 1;
        }

        class C : B, I
        {
            public int P => 2;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Show();

            Console.ReadKey();
        }
    }
}
