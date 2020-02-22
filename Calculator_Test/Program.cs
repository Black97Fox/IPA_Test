using System;

namespace Calculator_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integar 1>>");
            double num = Convert.ToDouble(Console.ReadLine()), TotallSum, TotallSub;
            Console.WriteLine("Enter integar 2>>");
            double num1 = Convert.ToDouble(Console.ReadLine()), TotallMulti, TotallDiv;
            Console.WriteLine("Calculator Menu:");
            Console.WriteLine("Press 1 for Sum");
            Console.WriteLine("Press 2 for Sub");
            Console.WriteLine("Press 3 for Multi");
            Console.WriteLine("Press 4 for Div");
            Console.WriteLine("Calculator Menu:");
            TotallSum = num + num1;
            TotallSub = num - num1;
            TotallMulti = num * num1;
            TotallDiv = num / num1;
            int Menu = Convert.ToInt32(Console.ReadLine());
            switch (Menu)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", num, num1, TotallSum);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", num, num1, TotallSub);
                    break;
                case 3:
                    Console.WriteLine("{0} * {1} = {2}", num, num1, TotallMulti);
                    break;
                case 4:
                    Console.WriteLine("{0} / {1} = {2}", num, num1, TotallDiv);
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
}
