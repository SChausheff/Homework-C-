using System;

class Program
{
    static void Main(string[] args)
    {
        int pullover = 15;
        int toy = 5;
        int adults = 0;
        int childs = 0;
        int integer ;
        string input;
        do
        {
            input = Console.ReadLine();
            if (int.TryParse(input ,out integer))
            {
                if (integer>16)
                {
                    adults++;
                }
                else
                {
                    childs++;
                }
            }
        } while (input!= "Christmas");
        Console.WriteLine("Number of adults: {0}",adults);
        Console.WriteLine("Number of kids: {0}",childs);
        Console.WriteLine("Money for toys: {0}",childs*toy);
        Console.WriteLine("Money for sweaters: {0}",adults*pullover);
    }
}

