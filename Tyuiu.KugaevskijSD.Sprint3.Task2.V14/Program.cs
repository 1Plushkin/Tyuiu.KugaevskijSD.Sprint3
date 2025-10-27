using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint3.Task2.V14.Lib;

namespace Tyuiu.KugaevskijSD.Sprint3.Task2.V14;
    class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- Спринт #3                                                               -");
        Console.WriteLine("- Оператор цикла do-while                                                 -");
        Console.WriteLine("- Задание #2                                                              -");
        Console.WriteLine("- Вариант #14                                                             -");
        Console.WriteLine("- Выполнил: Кугаевский Сергей Дмитриевич | АСОиУб-25-1                    -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- УСЛОВИЕ:                                                                -");

        Console.WriteLine("- Написать программу используя цикл do...while, которая вычисляет         -");
        Console.WriteLine("- произвение ряда по формуле, при x = 5                                     -");

        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        -");
        Console.WriteLine("---------------------------------------------------------------------------");

        Console.WriteLine("Переменная x = ");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Старт шага = ");
        int startValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Конец шага = ");
        int stopValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
        Console.WriteLine("---------------------------------------------------------------------------");

        DataService ds = new DataService();

        var result = ds.GetMultiplySeries(value, startValue, stopValue);
        Console.WriteLine("Произведение ряда = " + result);
        Console.ReadKey();
    }
}