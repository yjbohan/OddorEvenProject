using System;
using System.Globalization;

namespace OddorEvenProject
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.Write("Enter an integer: ");
            var response = Console.ReadLine();
            //Console.Write(response);
            var nbr = Convert.ToInt32(response);
            var isEven = true;
            if (nbr % 2 == 1)
                isEven = false;
            if (isEven)
            {
                Console.WriteLine($"The number {nbr} is even.");
            } else
            {
                Console.WriteLine($"The number {nbr} is odd.");
            }
        }
    }
}