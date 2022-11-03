using System;
namespace LogicalProblem
{
    public class Reverse
    {
        public void rnum(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                int reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num /= 10;
            }
            Console.WriteLine(reverse);
        }
    }
}