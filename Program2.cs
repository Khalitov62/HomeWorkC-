using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.Readline());
            int sum = 0;
            while (num > 0)
            { 
               sum += num %10
                    num /=10;
                Console.WriteLine(sum);
            }
        }
    }
}
