﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.EgovtsevMN.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double f = Math.Round(0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2), 2);
            File.WriteAllText(path, Convert.ToString(f));
            return path;  
        }
    }
}