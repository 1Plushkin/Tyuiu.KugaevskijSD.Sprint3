using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint3.Task4.V18.Lib;

namespace Tyuiu.KugaevskijSD.Sprint3.Task4.V18;

    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- Спринт #3                                                               -");
        Console.WriteLine("- Тема: Использование операторов continue и break в циклах                -");
        Console.WriteLine("- Задание #4                                                              -");
        Console.WriteLine("- Вариант #18                                                             -");
        Console.WriteLine("- Выполнил: Кугаевский С. Д. | АСОиУб-25-1                                -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- УСЛОВИЕ:                                                                -");
        Console.WriteLine("- На отрезке, где x принимает значения от -5 до 5, вычислить значение     -");
        Console.WriteLine("- функции y=sin(x)/cos(x) При х = 0 прервать цикл. Полученные значения    -");
        Console.WriteLine("- суммировать.                                                            -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- Функция y=sin(x)/cos(x)  									             -");
        Console.WriteLine("---------------------------------------------------------------------------");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
        Console.WriteLine("---------------------------------------------------------------------------");

        Console.WriteLine("Сумма ряда равна = " + ds.Calculate(startValue, stopValue));
        Console.ReadKey();

    }
}
