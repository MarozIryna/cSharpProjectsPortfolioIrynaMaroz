using System;

namespace project02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask write number.
            //If this number is even, write this number and this number in ^5.
            //If this number is divisible by 4, ask write second number.
            //Write sum and multiplication of 2 numbers.
            Console.WriteLine("Please write number: ");
            var number1 = Convert.ToDouble(Console.ReadLine());
            bool isEven = number1 % 2 == 0;
            Console.WriteLine("You wrote " + number1);
            Console.WriteLine("Fifth power of this number is : " + (number1 * number1 * number1 * number1 * number1));
            bool nesidalinaIs4 = number1 % 4 != 0;
            Console.WriteLine("Your next number is: ");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum of 2 numbers is " + (number1 + number2));
            Console.WriteLine("Multiplication of 2 numbers is " + (number1 * number2));
        }
    }
}
