using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyruntime
{
    internal class Polyruntime
    {
        static void Main(string[] args)
        {
            fivefunc obj = new fivefunc();
            obj.func();
            obj.func(2);
            obj.func("nambu");
            obj.func(3.20);
            int s = obj.func(2, 3);
            Console.WriteLine(s);
            Console.ReadKey();
        }
        class fivefunc
        {
            public void func()
            {
                Console.WriteLine("This is polymorphism");
            }
            public void func(int a)
            {
                int c = a + a;
                Console.WriteLine(c);
            }
            public void func(string name)
            {
                Console.WriteLine(name);
            }
            public void func(double num1)
            {
                double s = num1 * num1;
                Console.WriteLine(s);
            }
            public int func(int a , int b)
            {
                int d = a + b;
                return d;
            }
        }
    }
}
