using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatveevaAA.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {

                result[count] = Math.Round((2 * i - 3) / (Math.Cos(i) + i) + 5,2);
            count++;
            }

            return result;

        }
    }
}
