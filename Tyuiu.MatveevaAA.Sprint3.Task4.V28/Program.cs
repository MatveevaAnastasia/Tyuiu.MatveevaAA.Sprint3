using System;

using Tyuiu.MatveevaAA.Sprint3.Task4.V28.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Ответ: " + ds.Calculate(-5, 5));
        Console.ReadKey();
    }
}