using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFiveInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int number = 0;
            int sum = 0;
            while(number != 999)
            {
                Console.WriteLine("Insert No:" + count);
                number = Convert.ToInt32(Console.ReadLine());
                if(number != 999)
                {
                    sum = sum + number;
                }
                count = count + 1;
            }
            Console.WriteLine("The Sum is:" + sum);
        }
    }
}
