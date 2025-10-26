using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatveevaAA.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            const double x = 1.0;
            double p = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                double term = Math.Pow((0.5 + k / 5.0) / (Math.Cos(x) + 0.5), 3.0);
                p *= term;
                k++;
            }

            return Math.Round(p, 2); // 16947810.880588

        }
    }
}
