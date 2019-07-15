using System;


class Program
{
    static void Main(string[] args)
    {
        string sweets = Console.ReadLine();
        int sweetsCount = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        double cake, souffle, baklava;
        double check = 0;
        if (day <= 15)
        {
            cake = 24.0;
            souffle = 6.66;
            baklava = 12.6;

        }
        else
        {
            cake = 28.70;
            souffle = 9.80;
            baklava = 16.98;

        }
        switch (sweets)
        {
            case "Cake":
                 check = cake * sweetsCount;
                break;
                case "Souffle":
                check = souffle * sweetsCount;
                break;
            case "Baklava":
                check = baklava * sweetsCount;
                break;
            default:
                break;
        }
        check = Discount(check);
        double Discount(double bill)
        {
            if (day<=22)
            {
                if ((bill >= 100) && (bill <= 200))
                {
                    bill = bill - (bill * 0.15);
                }
                else if (bill > 200)
                {
                    bill = bill - (bill * 0.25);
                }
                if (day <= 15)
                {
                    bill = bill - (bill * 0.1);
                }
            }
            return bill;
        }
        Console.WriteLine("{0:f2}",check);
    }
}

