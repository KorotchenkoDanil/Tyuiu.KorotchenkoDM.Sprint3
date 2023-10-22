using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KorotchenkoDM.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            double i = startValue;
            do
            {
                MultiplySeries = MultiplySeries * Math.Pow(value / i, 3);
                i++;
            } while (i <= stopValue);
            return Math.Round(MultiplySeries, 3);
        }
    }
}
