using System;

using Tyuiu.MatveevaAA.Sprint3.Task1.V21.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Матвеева Анастасия Андреевна | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3 | Тема: Оператор цикла while                                  *");
        Console.WriteLine("* Задание #1 | Вариант #21                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("p = Π_{k=1..12} ((0.5 + k/5) / (cos(1) + 0.5))^3");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetMultiplySeries(1, 1, 12);   // x = 1 зашит в библиотеке
        Console.WriteLine($"Результат" + result);
        Console.ReadKey();
    }
}
