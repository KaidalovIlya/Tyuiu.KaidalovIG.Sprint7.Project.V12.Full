using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.KaidalovIG.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public double SredOZU(string[,] path)
        {
            double sum = 0;                                  //объявляем переменную
            for (int i = 1; i < path.GetLength(0); i++)      //создаём цикл, который проходит по всем строкам 2-х мерного массива
            {
                sum += Convert.ToDouble(path[i, 4]);         //добавляем в переменную значение элемента массива path 
            }
            double average = sum / (path.GetLength(0) - 1);  //вычисляем среднее значение sum по всем строкам массива path (кроме первой) и сохраняем 
            return Math.Round(average, 2);                   //округляем до 2=х знаков и возвращаем результат                     результат в average
        }

        public double MaxYadra(string[,] path)
        {
            double max = 0;
            int columnIndex = 3;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, columnIndex]) > max)
                {
                    max = Convert.ToDouble(path[i, columnIndex]);
                }
            }
            return max;
        }
    }
}
