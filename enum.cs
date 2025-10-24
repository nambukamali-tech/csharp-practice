using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bank bk = bank.current;
            Console.WriteLine("The bank type is" + bk);

        }
        enum bank
        {
            current=1,
            savings=2,
            balance =0
          
        }
    }
}
