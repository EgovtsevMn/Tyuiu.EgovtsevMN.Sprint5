﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.EgovtsevMN.Sprint5.Task6.V13.Lib;

namespace Tyuiu.EgovtsevMN.Sprint5.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Еговцев М. Н. | АСОиУб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #6                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Еговцев Максим Николаевич | АСОиУб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask6V13.txt в котором есть        *");
            Console.WriteLine("* набор символьных данных. Найти количество удвоенных букв \"сс\" в заданной*");
            Console.WriteLine("* строке.                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("В строке находится " + ds.LoadFromDataFile(path) + " удвоенных букв \"с\"");
            Console.ReadKey();
        }
    }
}
