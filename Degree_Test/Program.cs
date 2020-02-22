using System;

namespace Degree_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Degree>>");
            const char e = 'e', v = 'v', g = 'g', a = 'a', f = 'f';
            char degree = Convert.ToChar(Console.ReadLine());
            switch (degree)
            {
                case e:
                    Console.WriteLine("Excellent");
                    break;
                case v:
                    Console.WriteLine("Very Good");
                    break;
                case g:
                    Console.WriteLine("Good");
                    break;
                case a:
                    Console.WriteLine("Average");
                    break;
                case f:
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
