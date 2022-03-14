using System;

namespace BasicLogicalProgramming
{
    public class Program
    {
        //Reverse the number. 

        static void Main(string[] args)
        {
            int number, remainder;
            int reverse = 0;

            Console.Write("Enter a number to reverse it: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            Console.Write("Reversed Number is: " + reverse);
        }

    }
}