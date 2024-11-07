using Tyuiu.RaushKN.Sprint6.Task6.V5.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @$"C:\DataSprint6\InPutDataFileTask6V5.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "ulzPXa sMLuPzlvneiTo tfouGdncXlJ";

            Assert.AreEqual(wait, res);
        }
    }
}