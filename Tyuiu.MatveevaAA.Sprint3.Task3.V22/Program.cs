using System;

using Tyuiu.MatveevaAA.Sprint3.Task3.V22.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Ответ: " + ds.GetMaxCharCount("tbtbbb dsfbg bbg", 'b'));
        Console.ReadKey();
    }
}