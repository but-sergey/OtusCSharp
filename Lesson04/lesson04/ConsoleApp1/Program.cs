using System;

namespace ConsoleApp1
{
    interface ISample
    {
        void SampleMethod();
    }

    interface ISample2
    {
        void SampleMethod();
    }

    abstract class Foo : ISample
    {
        public abstract void SampleMethod();
    }

    class Foo2 : Foo
    {
        public override void SampleMethod()
        {
            Console.WriteLine("Вызван метод");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Foo2 foo2 = new Foo2();
            ISample sample = foo2;
            sample.SampleMethod();

            Console.ReadLine();
        }
    }
}
