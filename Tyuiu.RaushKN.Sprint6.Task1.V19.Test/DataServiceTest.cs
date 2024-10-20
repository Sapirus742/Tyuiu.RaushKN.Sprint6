using Tyuiu.RaushKN.Sprint6.Task1.V19.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task1.V19.Test
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
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[11] { 15.19, 11.67, 9.0, 0, 4.08, 1.5, -2.28, -6.52, -10.19, -12.76, -14.68 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}