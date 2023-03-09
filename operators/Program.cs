using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            Console.WriteLine("First Number = {0}", firstNumber);
            int secondNumber = 20;
            Console.WriteLine("First Number = {0} and this is the second {1}", firstNumber, secondNumber);

            //arithmetic operators
            Console.WriteLine(23 + 45);
            Console.WriteLine(23 - 45);
            Console.WriteLine(23 * 45);
            Console.WriteLine(23 / 45);
            Console.WriteLine(23 % 45);
            
        }
    }
}
