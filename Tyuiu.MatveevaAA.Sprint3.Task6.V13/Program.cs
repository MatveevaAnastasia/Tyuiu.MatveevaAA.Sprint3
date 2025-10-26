using System;

using Tyuiu.MatveevaAA.Sprint3.Task6.V13.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Ответ: " + ds.GetSumTheDivisors(8, 17));
        Console.ReadKey();
    }
}
