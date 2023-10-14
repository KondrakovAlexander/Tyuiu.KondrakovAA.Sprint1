using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KondrakovAA.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, y, x1, y1;
            DataService resp = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Кондраков А.А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y1: ");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(resp.DistanceBetweenDots(x, y, x1, y1));
            Console.ReadKey();

        }
    }
}
