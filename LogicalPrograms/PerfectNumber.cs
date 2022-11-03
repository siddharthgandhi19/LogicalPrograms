using System;
namespace LogicalProblem

{
    public class PerfectNumber
    {
        public void Check(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (num == sum)
                Console.WriteLine("Number provided is Perfect Number");
            else
                Console.WriteLine("Number provided is not a Perfect Number");
        }
    }
}