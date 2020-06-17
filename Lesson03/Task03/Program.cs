using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        class A
        {
            public virtual void Foo() => Console.WriteLine("A");
        }

        class B : A
        {
            public override void Foo() => Console.WriteLine("B");
        }

        class C : A
        {
            public new void Foo() => Console.WriteLine("C");
        }

        class D : A
        {
            public void Foo() => Console.WriteLine("D");
        }

        class E : B
        {
            public new void Foo() => Console.WriteLine("E");
        }

        static void Main(string[] args)
        {
            //A a = new A();
            //a.Foo();

            //B b1 = new A();
            //b1.Foo();

            //A b2 = new B();
            //b2.Foo();

            //A c = new C();
            //c.Foo();

            //B b3 = new C();
            //b3.Foo();

            //D d = new D();
            //d.Foo();

            E e = new E();
            e.Foo();

            Console.ReadKey();
        }
    }
}
