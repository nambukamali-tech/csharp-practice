using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensional_array
{
    internal class multidimensionalArray
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 6 }, { 9, 10, 5 } };//two dimensional array first{} is 0 and second {} is 1
            Console.WriteLine(numbers[0,2]);//Accessing first{} element so 0 and the 2nd index value
            object[] mixedarray = new object[3];//create array with different data types but we only provide the same type of data within normal declaration of array
            mixedarray[0] = "Nambu";
            mixedarray[1] = 1;
            mixedarray[2] = true;
            foreach (object obj in mixedarray)
            {
                Console.WriteLine(obj);
             

            }
            //some functions in array we import linq namespace
            
            Console.ReadKey();

        }
    }
}
