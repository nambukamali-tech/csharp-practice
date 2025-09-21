using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace banking_system_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bank bk = new bank();
            int choice;
            do
            {
                Console.WriteLine("Welcome to the axis bank");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Enter your choice (1/2/3/4)");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bk.createaccount();
                        break;
                    case 2:
                        bk.deposit();
                        break;
                    case 3:
                        bk.withdraw();
                        break;
                    case 4:
                        bk.showbalance();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }

            } while (choice != 5);

        }
    }
    class bank
    {
        public string accountholdername;
        public int accountno;
        public double initialamt;
        public double balance;

        public void createaccount()
        {
            Console.WriteLine("Enter the Account Holder Name:");
            accountholdername = Console.ReadLine();
            Console.WriteLine("Enter the Account Number:");
            accountno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Initial amount:");
            initialamt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Account Created Successfully");
                
        }
        public void deposit()
        {
            
            Console.WriteLine("Enter the Amount to deposit:");
            double deposit = Convert.ToDouble(Console.ReadLine());
            if (deposit > 0)
            {
                balance = deposit+initialamt;
                Console.WriteLine($"Your Amount {deposit} Deposited Successfully");
            }
        }
        public void withdraw()
        {
            Console.WriteLine("Enter the amount for Withdraw:");
            double drawamt = Convert.ToDouble(Console.ReadLine());
            if (drawamt <= balance)
            {
                balance -= drawamt;
                Console.WriteLine("Amount withdraw successfully");

            }
            else
            {
                Console.WriteLine("Sorry! Insufficient balance in your account");
            }

        }
        public void showbalance()
        {
            Console.WriteLine($"Accountholdername : {accountholdername}");
            Console.WriteLine($"AccountNo: {accountno}");
            Console.WriteLine($"Available Balance : {balance}");
        }

    }
}
