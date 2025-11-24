using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            info2 data = new info2();
            int a = data.sample1(10, 30);
            int b =data.sample2(40, 50);
            Console.WriteLine(a);
            Console.WriteLine(b);
       
        }
        class info1
        {
            public int sample1(int x , int y)
            {
                int z = x + y;
                return z;
            }
        }
        class info2 : info1
        {
            public int sample2(int x , int y)
            {
                int k = x + y;
                return k;
            }
        }
    }
}
