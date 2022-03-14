using System;

namespace BasicLogicalProgramming
{
    public class Program
    {
        //Generate a random Coupon. 

        static void Main(string[] args)
        {
            var nDistinct = "0123456789";

            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = nDistinct[random.Next(nDistinct.Length)];
            }

            var finalCoupon = new String(stringChars);
            Console.WriteLine("Generated Coupon number is "+finalCoupon);
        }
    }
}
