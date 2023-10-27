using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KorotchenkoDM.Sprint3.Task7.V20.Lib
{
    public class DataService : ISprint3Task7V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue + 1);
            valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x - 1 == 0)
                {
                    valueArray[count] = 0;
                    continue;
                }
                double y = Math.Round((Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2, 2);
                valueArray[count] = y;
                count++;

            }
            return valueArray;
        }
    }
}
