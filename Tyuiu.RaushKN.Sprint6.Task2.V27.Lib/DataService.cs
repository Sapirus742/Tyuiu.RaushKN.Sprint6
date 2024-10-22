using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RaushKN.Sprint6.Task2.V27.Lib
{
    public class DataService : ISprint6Task2V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int i = 0;
            double[] res = new double[11];
            for (int x = startValue;  x <= stopValue; x++)
            {
                if (Math.Cos(i) - 2*i == 0)
                {
                    res[i] = 0;
                    i++;
                    continue;
                }
                res[i] = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x), 2);
                i++;
            }

            return res;
        }
    }
}
