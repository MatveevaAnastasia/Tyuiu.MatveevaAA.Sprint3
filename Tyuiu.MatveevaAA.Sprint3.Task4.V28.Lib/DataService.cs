using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatveevaAA.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28

    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) { continue; }
                y += (Math.Cos(i) + Math.Sin(i)) / i;
            }
             return Math.Round(y,3);
        }
    }
}
