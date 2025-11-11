using Tyuiu.MarakovAD.Sprint4.Task0.V29.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Мараков А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами                                 *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Мараков Андрей Дмитриевич | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный " +
            "статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива." +
            "  {7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
        Console.WriteLine("Массив:");
        for (int i = 0; i <= array.Length - 1; i++) { 
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int sum = ds.GetSumOddArrEl(array);
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}