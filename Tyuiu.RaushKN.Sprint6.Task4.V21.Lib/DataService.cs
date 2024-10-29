using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RaushKN.Sprint6.Task4.V21.Lib
{
    public class DataService : ISprint6Task4V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[11];
            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 * x - 1 == 0)
                {
                    res[i] = 0;
                    i++;
                    continue;
                }
                res[i] = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
                i++;
            }
            
            return res;
        }
    }
}
