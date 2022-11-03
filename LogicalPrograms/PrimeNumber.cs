using System;
namespace LogicalProblem
{
    public class PrimeNumber
    {
        public void CheckPrime(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("Number is Prime");
            else
                Console.WriteLine("Number is not a Prime");
        }
    }
}