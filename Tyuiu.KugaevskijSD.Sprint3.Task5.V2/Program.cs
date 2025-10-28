using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint3.Task5.V2.Lib;

namespace Tyuiu.KugaevskijSD.Sprint3.Task5.V2;
    class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- Спринт #3                                                               -");
        Console.WriteLine("-                                                                         -");
        Console.WriteLine("- Задание #5                                                              -");
        Console.WriteLine("- Вариант #2                                                              -");
        Console.WriteLine("- Выполнил: Кугаевский С. Д. | АСОиУБ-25-1                                -");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
        Console.WriteLine("---------------------------------------------------------------------------");

        Console.WriteLine("введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите 1 начальное значение: ");
        int startValue1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите 1 конечное значение: ");
        int stopValue1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите 2 начальное значение: ");
        int startValue2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите 2 конечное значение: ");
        int stopValue2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("-                                                                         -");
        Console.WriteLine("---------------------------------------------------------------------------");

        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
        Console.WriteLine("---------------------------------------------------------------------------");

        DataService ds = new DataService();

        var result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
