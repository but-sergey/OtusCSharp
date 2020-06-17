using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        public void Show()
        {
            A a = new B();
        }

        public class A
        {
            public A()
            {
                Console.WriteLine("Constructor A called");
                Console.WriteLine($"B value = {B.value}");
            }
        }

        public class B : A
        {
            public B() => Console.WriteLine("Constructor B called");
            static B()
            {
                value = 0;
                Console.WriteLine("Static constructor B called");
            }
            public static int value = 1;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Show();

            Console.ReadKey();
        }
    }
}
