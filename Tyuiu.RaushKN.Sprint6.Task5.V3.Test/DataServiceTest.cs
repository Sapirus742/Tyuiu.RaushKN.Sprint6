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
            string path = $@"C:\Users\rausc\source\repos\Tyuiu.RaushKN.Sprint6\Tyuiu.RaushKN.Sprint6.Task5.V3.Lib\InPutDataFileTask5V3.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] {1, 2.5, 3, 5.7, 6, 7, 8, 9.9, 10, };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}