using Tyuiu.RaushKN.Sprint6.Task5.V3.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\rausc\source\repos\Tyuiu.RaushKN.Sprint6\Tyuiu.RaushKN.Sprint6.Task5.V3\bin\Debug\net8.0-windows\InPutDataFileTask5V3.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] { 2.5 , -2.6, 5.7, -6.8, 9.9 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}