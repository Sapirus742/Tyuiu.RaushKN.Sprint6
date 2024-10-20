using Tyuiu.RaushKN.Sprint6.Task0.V12.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 1.741;

            Assert.AreEqual(wait, res);
        }
    }
}