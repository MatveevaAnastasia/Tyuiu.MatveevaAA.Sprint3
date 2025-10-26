using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatveevaAA.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14

    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1.0;
            int k = startValue;
            double x = value;

            do
            {
                p *= Math.Pow(x/ k, 3.0);   // важно: x — double, деление вещественное
                k++;
            }
            while (k <= stopValue);

            return Math.Round(p, 3);         // → 0.000098

        }
    }
}
