using System;

using Tyuiu.MatveevaAA.Sprint3.Task5.V16.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Ответ: " + ds.GetSumSumSeries(2, 1, 1, 3, 10));
        Console.ReadKey();
    }
}