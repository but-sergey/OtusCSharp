using System;

namespace ConsoleApp1
{
    interface ISample
    {
        void SampleMethod();
    }

    interface ISample2
    {
        void SampleMethod2();
    }

    class Foo : ISample
    {
        public void SampleMethod()
        {
            Console.WriteLine("Вызван метод");
        }
    }

    class Foo2:ISample, ISample2
    {
        public void SampleMethod()
        {
            Console.WriteLine("Вызван метод");
        }

        public void SampleMethod2()
        {
            Console.WriteLine("Вызван метод 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //error
            //ISample sample = new ISample();
            ISample foo = new Foo();
            foo.SampleMethod();

            Foo2 foo2 = new Foo2();
            ISample sample = foo2;
            sample.SampleMethod();

            ISample2 sample2 = foo2;
            sample2.SampleMethod2();
        }
    }
}
