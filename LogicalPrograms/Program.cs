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
                Console.WriteLine("1. Fibonaccis Series" + "\n" + "2. Check Perfect Number" + "\n" + "3. PrimeNumber" + "\n" + "4. Reverse enter" + "\n" + "5. Coupon Number" + "\n" + "6. Temperature Conversion" + "\n" + "7. Exit");
                    
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
                    case 3:
                        PrimeNumber pri = new PrimeNumber();
                        pri.CheckPrime(10);
                        break;
                   case 4:
                        Reverse rev = new Reverse();
                        rev.rnum(25);
                        break;
                    case 5:
                        CouponNumber.GenerateCoupon(10);
                        break;
                    case 6:
                        Temperature tem = new Temperature();
                        tem.temp1();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}

 