using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicitcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 300;
            Type typenum = num.GetType();
            //explicit
            int num2 = (int)num;
            Type typenum2 = num2.GetType();
            //print
            Console.WriteLine($"The value of num{num}");
            Console.WriteLine($"The type of num{typenum}");
            Console.WriteLine($"The value of num2{num2}");
            Console.WriteLine($"The type of num2{typenum2}");
            Console.ReadKey();

            
           
        }
    }
}
