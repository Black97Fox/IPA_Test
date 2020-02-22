using System;

namespace Weather_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Temp>>");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("Freezing Weather");
            }
            else if (temp <= 10)
            {
                Console.WriteLine("Very cold Weather");
            }
            else if (temp <= 20)
            {
                Console.WriteLine("Cold Weather");
            }
            else if (temp <= 30)
            {
                Console.WriteLine("Normal Weather");
            }
            else if (temp <= 40)
            {
                Console.WriteLine("It's Hot");
            }
            else if (temp <= 50)
            {
                Console.WriteLine("It's Very Hot");
            }
            else
            {
                Console.WriteLine("The world is MELTING");
            }
        }
    }
}
