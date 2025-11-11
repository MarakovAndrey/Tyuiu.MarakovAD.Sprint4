using System.ComponentModel.DataAnnotations;
using Tyuiu.MarakovAD.Sprint4.Task6.V15.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Мараков А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами                                 *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Мараков Андрей Дмитриевич | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных " +
            "[Чикаго, Хьюстон, Феникс, Филадельфия, Сан - Антонио, Сан - Диего, Даллас]" +
            " используя класс Array подсчитайте количество элементов, длина которых меньше 7.");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        var week = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
        Console.WriteLine("Массив: ");
        for (int i = 0; i < week.Length - 1; i++)
        {
            Console.Write(week[i]);
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int sum = ds.Calculate(week);
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}