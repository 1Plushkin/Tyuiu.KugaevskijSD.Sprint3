using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint3.Task6.V9.Lib;

namespace Tyuiu.KugaevskijSD.Sprint3.Task6.V9;

    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- Спринт #3                                                               -");
        Console.WriteLine("- Тема: Обработка целочисленной информации                                -");
        Console.WriteLine("- Задание #6                                                              -");
        Console.WriteLine("- Вариант #9                                                              -");
        Console.WriteLine("- Выполнил: Кугаевский Сергей Дмитриевич | АСОиУб-25-1                    -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- УСЛОВИЕ:                                                                -");
        Console.WriteLine("- Написать программу, которая запрашивает у пользователя исходные данные, -");
        Console.WriteLine("- выполняет указанные расчёты и печатает результат на экране.             -");
        Console.WriteLine("-                                                                         -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
        Console.WriteLine("---------------------------------------------------------------------------");
        int startValue = Convert.ToInt32(Console.ReadLine());
        int stopValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
        Console.ReadKey();

    }
}
