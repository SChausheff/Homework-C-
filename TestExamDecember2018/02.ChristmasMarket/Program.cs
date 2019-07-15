using System;

class Program
{
    static void Main(string[] args)
    {
        double targetProfit = double.Parse(Console.ReadLine());
        int fantasyCount = int.Parse(Console.ReadLine());
        int horrorCount = int.Parse(Console.ReadLine());
        int romanticCount = int.Parse(Console.ReadLine());
        double fantasyPrice = 14.90;
        double horrorPrice = 9.80;
        double romantikPrice = 4.30;
        double sales = (fantasyPrice*fantasyCount)+(horrorPrice*horrorCount)+(romanticCount*romantikPrice);
        sales = sales - (sales * 0.2);
        if (sales<targetProfit)
        {
            UnreachedTarget();
        }
        else
        {
            ReachedTarget();
        }
        void ReachedTarget()
        {
            double sellersProfit = Math.Floor((sales - targetProfit) * 0.1);
            double donatedMoney = sales - sellersProfit;
            Console.WriteLine("{0:F2} leva donated.",donatedMoney);
            Console.WriteLine("Sellers will receive {0:F0} leva.",sellersProfit);
        }
        void UnreachedTarget()
        {
            double neededMoney = targetProfit - sales;
            Console.WriteLine("{0:f2} money needed.",neededMoney);
        }
    }
}

