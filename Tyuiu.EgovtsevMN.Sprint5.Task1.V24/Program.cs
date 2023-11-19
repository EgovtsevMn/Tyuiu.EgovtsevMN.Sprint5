﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.EgovtsevMN.Sprint5.Task1.V24.Lib;

namespace Tyuiu.EgovtsevMN.Sprint5.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Еговцев М.Н. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Еговцев Максим Николаевич | АСОиУб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, (произвести табулирование) f(x) на заданном диапазоне     *");
            Console.WriteLine("* [-5;5] с шагом 1. Произвести проверку деления на 0. При делении на 0    *");
            Console.WriteLine("* вернуть значение 0.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
