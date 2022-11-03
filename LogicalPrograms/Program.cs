using System;
namespace LogicalProblem

{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Logical Programming Problems");
                Console.WriteLine("1. Fibonaccis Series" + "\n"  + "2. Check Perfect Number" + "\n" + "3. Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FibonacciSeries fibo = new FibonacciSeries();
                        fibo.Print(10);
                        break;
                    case 2:
                        PerfectNumber enter = new PerfectNumber();
                        enter.Check(28);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}

 