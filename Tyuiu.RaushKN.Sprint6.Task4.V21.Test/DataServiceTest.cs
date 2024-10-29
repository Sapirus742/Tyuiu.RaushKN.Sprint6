using Tyuiu.RaushKN.Sprint6.Task4.V21.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = new double[11];
            res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[] { 28.05, 22.27, 17.01, 12.35, 7.51, 0, 1.62, -7.03, -12.99, -17.55, -21.43 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}