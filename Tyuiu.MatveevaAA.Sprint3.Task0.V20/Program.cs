using System;

using Tyuiu.MatveevaAA.Sprint3.Task0.V20.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        double result = ds.GetMultiplySeries(1, 1, 14);

        Console.Title = "Спринт #3 | Выполнил: Матвеева Анастасия Андреевна | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3 | Тема: Оператор цикла for                                    *");
        Console.WriteLine("* Задание #0 | Вариант #20                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("p = Π_{k=1..14} (cos(1) + (k/8)^3)");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Результат" + result);
        Console.ReadKey();
    }
}