///Shanmukh Gopinath Mandava
/// UMID: 13136658
/// WINTER 2022
/// CIS 297 - C SHARP
/// Assignment 03

/// Dear Professor, I am using a Macbook Pro and VISUAL STUDIO on mac doesnt support the feature to generate UML Diagrams.
/// I have tried to see if can unable extensions of class diagrams but i couldn't.
/// Hope you understand and excuse me in submitting the UML diagram.
/// Thank you!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// Account balances such as credit and debit are stored and calcualted here
    /// </summary>
    class Account
    {
        private double balance = 100000;


        public double balnc
        {
            get { return balance; }
            set { balance = value; }
        }
        public string name;
        public double account, final_Amt;
        public double withdraw, dep, tobal;

        public void credit()
        {
            Console.WriteLine("Enter the name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Credit Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            tobal = balnc + dep;

            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + tobal);

        }
        public void debit()
        {
            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= balnc)
            {
                tobal = balnc - withdraw;
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Withdraw balnace Amount is : " + tobal);
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
        }

    }
    /// <summary>
    /// interest rate is calculated in this class
    /// </summary>
    class Saving_Account : Account
    {
        double interest_rate, rate;
        public void calculateintrest()
        {
            interest_rate = 0.02;
            //calculation
            rate = tobal * (interest_rate / 100);
            final_Amt = tobal + rate;
            Console.WriteLine("Total Balance Amount with Interest : " + final_Amt);
        }

    }
    /// <summary>
    /// Here checking Account subtracts the fee per transacation
    /// </summary>
    class CheckingAccount : Saving_Account
    {
        double fee_per = 15;
        public void fee()
        {
            Console.WriteLine("Balance After Transection Charges : " + (tobal - fee_per));
        }

    }
    /// <summary>
    /// Main function to call the methods to check credit, calculate Intrest,debit and fee
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            char agn;
            do
            {
                CheckingAccount i = new CheckingAccount();
                int num;
                Console.WriteLine("Please Select Any Function.");
                Console.WriteLine("\nPress 1 for Credit an Amount. \nPress 2 for debit an Amount.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        i.credit();
                        i.calculateintrest();
                        break;
                    case 2:
                        i.debit();
                        i.fee();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");
               // agn = Convert.ToChar(Console.ReadLine());
                agn = Console.ReadKey().KeyChar;

            } while (agn == 'y');
            Console.ReadKey();
        }
    }
}
