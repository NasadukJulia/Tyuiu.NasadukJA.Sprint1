﻿using Tyuiu.NasadukJA.Sprint1.Task0.V8.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#.                                       *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет выражение 15 / 2 / 4              *");
Console.WriteLine("* и печатает результат на экране.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* 15 / 2 / 4                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate());

Console.ReadLine();

