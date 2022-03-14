using System;

namespace BasicLogicalProgramming
{
    public class Program
    {
        //Fibonacci series 

        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;

            Console.Write("Enter number to get febbonaci series : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Febonnacci Series : " + a +" " + b);

            for (int i = 0; i < N; i++)
            {
                c = a + b;
                Console.Write(" "+c);
                a = b;
                b = c;
            }
        }
    }
}