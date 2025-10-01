using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            maths mat = new maths();
            mat.add(20, 30);
            mat.mul(30, 40);
            Console.ReadKey();
        }
        interface mat1
        {
            void add(int a,int b);
        }
        interface mat2
        {
            void mul(int a , int b);
        }
        class maths : mat1 , mat2
        {
            public void add(int a , int b)
            {
                int c = a + b;
                Console.WriteLine("The value is:" + c);
            }
            public void mul(int a , int b)
            {
                int e = a * b;
                Console.WriteLine("The value is " + e);
            }
        }
    }
}
