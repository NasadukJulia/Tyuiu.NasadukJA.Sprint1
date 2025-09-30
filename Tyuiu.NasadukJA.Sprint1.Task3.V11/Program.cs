using Tyuiu.NasadukJA.Sprint1.Task3.V11.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет площадь треугольника,             *");
Console.WriteLine("* исходя из координат его углов.                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x1 = -2;
double y1 = 5;
double x2 = 1;
double y2 = 7;
double x3 = 5;
double y3 = -3;
Console.WriteLine("Координата треугольника х1 = " + x1);
Console.WriteLine("Координата треугольника y1 = " + y1);
Console.WriteLine("Координата треугольника х2 = " + x2);
Console.WriteLine("Координата треугольника y2 = " + y2);
Console.WriteLine("Координата треугольника х3 = " + x3);
Console.WriteLine("Координата треугольника y3 = " + y3);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Площадь треугольника = " + ds.TriangleArea(x1, y1, x2, y2, x3, y3));

Console.ReadLine();
