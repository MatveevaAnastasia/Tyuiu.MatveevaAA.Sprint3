using System;

using Tyuiu.MatveevaAA.Sprint3.Task2.V14.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Матвеева Анастасия Андреевна | ПКТб-25-1";
        Console.WriteLine("p = Π_{k=1..6} (k/x)^3,  x = 5");


        double result = ds.GetMultiplySeries(5, 1, 6);
        Console.WriteLine($"Результат" + result);
        Console.ReadKey();
    }
}