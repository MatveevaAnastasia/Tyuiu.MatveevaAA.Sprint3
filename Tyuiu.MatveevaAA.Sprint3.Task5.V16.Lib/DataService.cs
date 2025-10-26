using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatveevaAA.Sprint3.Task5.V16.Lib
{
    public class DataService : ISprint3Task5V16


    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    sumSeries += Math.Cos(j) + x * x;
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
