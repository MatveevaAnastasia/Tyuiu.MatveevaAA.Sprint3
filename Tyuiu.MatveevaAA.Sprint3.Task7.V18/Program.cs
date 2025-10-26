using System;

using Tyuiu.MatveevaAA.Sprint3.Task7.V18.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Ответ: " + ds.GetMassFunction(-5, 5));

        int startValue = -5, stopValue = 5;
        double[] valueArray = new double[stopValue - startValue + 1];
        valueArray = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("+---------+---------+");
        Console.WriteLine("|    X    |  f(x)   |");
        Console.WriteLine("|---------|---------|");
        for (int i = 0; i < valueArray.Length; i++)
        {
            Console.WriteLine("|---------|---------|");
            Console.WriteLine("|{0,5:d}    |  {1,6:f2} |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+---------+---------+");

        Console.ReadKey();
    }
}

