using System;

class Program
{
    static void Main(string[] args)
    {
        double baklavaPrice = double.Parse(Console.ReadLine());
        double muffinPrice = double.Parse(Console.ReadLine());
        double stolenKilo = double.Parse(Console.ReadLine());
        double candyKilo = double.Parse(Console.ReadLine());
        double biscuitsKilo = double.Parse(Console.ReadLine());
        double stolenPrice = baklavaPrice + (baklavaPrice*0.6);
        double candyPrice = muffinPrice + (muffinPrice*0.8);
        double biscuitsPrice = 7.5;
        double tottalPrice = (stolenKilo * stolenPrice) + (candyKilo * candyPrice) + (biscuitsKilo * biscuitsPrice);
        Console.WriteLine("{0:f2}",tottalPrice);
    }
}

