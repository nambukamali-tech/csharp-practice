using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopingstatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=rows;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
               
            }
        }
    }
}
