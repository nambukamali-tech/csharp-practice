using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to Check");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for(int i = 2; i<n/2; i++)
            {
                if(n%i == 0)
                {
                    isPrime = false;
                    break;
                    
                }
            }
            if(isPrime && n>1)
            {
                Console.WriteLine($"{n} is a prime");
            }
            else
            {
                Console.WriteLine($"{n} is not prime");
            }

        }
    }
}
