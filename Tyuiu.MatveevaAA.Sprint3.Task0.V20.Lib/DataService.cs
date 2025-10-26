using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatveevaAA.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double s = 1;
            for (double i =startValue; i <= stopValue; i++)
            {
                s *= (Math.Pow(i / 8, 3) + Math.Cos(value));
            }
            return Math.Round(s, 3);
        }
    }
}
