using System;

namespace BasicLogicalProgramming
{
    public class Program
    {
        //Find a Perfect number. 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check the Perfect Number");
            int Number =Convert.ToInt32(Console.ReadLine());
            int perfectN = 0;

            for (int i = 1; i < Number; i++)
            {
                if (Number % i ==0)
                {
                    Console.WriteLine("Positive divisor is : "+i);
                    perfectN += i;
                }
                
            }
            if (perfectN == Number)
            {
                Console.WriteLine(perfectN + " : is a Perfect Number");
            }
            else
            {
                Console.WriteLine(perfectN + " : is not a Perfect Number");
            }
        }
    }
}