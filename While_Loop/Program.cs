using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            double BankBal = 1000;
            const double Int_Rate = 0.04;
            string inputString;
            char response;
            Console.Write("Do you want to see your balance? Y or N ...");
            inputString = Console.ReadLine();
            response = Convert.ToChar(inputString);
            while(response == 'Y')
            {
                Console.WriteLine("Bank balance is {0}",BankBal);
                BankBal = BankBal + BankBal * Int_Rate;
                Console.Write("Do you want to see next year's balance? Y or N...");
                inputString = Console.ReadLine();
                response = Convert.ToChar(inputString);
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}
