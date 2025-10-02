using Tyuiu.NasadukJA.Sprint1.Task7.V21.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*            x             2                                              *");
Console.WriteLine("*           y         sin(x  ) + cos(y)                                   *");
Console.WriteLine("* z = ------------- + ----------------- * tg(xy)                          *");
Console.WriteLine("*               x                                                         *");
Console.WriteLine("*     cos(x) - ---     cos(x) - sin(y)                                    *");
Console.WriteLine("*               3                                                         *");

double x, y;
Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();