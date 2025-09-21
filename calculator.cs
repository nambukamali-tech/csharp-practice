using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_in_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator calc = new calculator();
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operator you perform (+,-,*,/,%)");
            string op = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            bool valid = true;
            
            switch (op)
            {
                
                case "+":
                    result = calc.add(num1, num2);
                    break;
                case "-":
                   result = calc.subtract(num1, num2);
                    break;
                case "*":
                     result = calc.multiply(num1, num2);
                    break;
                case "/":
                    result = calc.divide(num1, num2);
                    break;
                case "%":
                    result = calc.mod(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid Expression ");
                    valid = false;
                    break;
            }
            if (valid)
            {
                Console.WriteLine($"The Result of {num1} {op} {num2} is : {result}");
            }
            Console.ReadKey();
        }



        class calculator
        {
            public double add(double num1, double num2)
            {
                return num1 + num2;
            }
            public double subtract(double num1, double num2)
            {
                return num1 - num2;
            }
            public double multiply(double num1, double num2)
            {
                return num1 * num2;
            }
            public double divide(double num1, double num2)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("The number not divide by zero");
                    return 0;
                }
                return num1 / num2;
            }
            public double mod(double num1 , double num2)
            {
                return num1 % num2;
            }
        }
    }

}