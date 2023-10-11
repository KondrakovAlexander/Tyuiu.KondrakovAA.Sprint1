using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KondrakovAA.Sprint1.Task2.V18.Lib
{
    public class DataService : ISprint1Task2V18
    {
        public int CalculateSideSquareParallelepiped(int a, int b, int c) 
        {
            return 2 * (a*b + b*c + a*c);
        }
    }
}
