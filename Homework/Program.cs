using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 678;
            int floor = 0;
            int x = 0;
            while (number != 0)
            {
                x = number % 10;
                number -= x;
                number /= 10;
                floor++;
            }
            Console.WriteLine(floor);
        }
    }
}
