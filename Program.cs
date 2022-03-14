using System;

namespace BasicLogicalProgramming
{
    public class Program
    {
        //Find a Prime number. 

        static void Main(string[] args)
        {
            int number;
            int nBy2;
            int flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            number = Convert.ToInt32(Console.ReadLine());
            nBy2 = number / 2;
            if (number>1)
            {
                for (int i = 2; i <= nBy2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write(number +" is not a Prime Number.");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.Write(number+" is a Prime Number.");
            }
            else
            {
                Console.WriteLine("Invalid Number, Ensure number must be greater than 1");
            }
        }
    }
}