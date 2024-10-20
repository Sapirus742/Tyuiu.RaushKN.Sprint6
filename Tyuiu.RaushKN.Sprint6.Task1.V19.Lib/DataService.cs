using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RaushKN.Sprint6.Task1.V19.Lib
{
    public class DataService : ISprint6Task1V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int i = 0;
            double[] res = new double[11];
            for (int x= startValue; x<=stopValue; x++)
            {
                if (x + 2 == 0)
                {
                    res[i] = 0;
                    i++;
                    continue;
                }
                res[i] = Math.Round(Math.Cos(x) + Math.Cos(x) / (x + 2) - 3 * x, 2);
                i++;
            }
            return res;
        }
    }
}
