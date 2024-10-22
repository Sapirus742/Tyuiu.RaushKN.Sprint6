using Tyuiu.RaushKN.Sprint6.Task2.V27.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = new double[11];
            res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[11] { -27.22, -22.25, -16.66, -11.04, -6.13, -3.0, 4.84, 8.86, 14.43, 20.18, 25.24 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}