using Tyuiu.RaushKN.Sprint6.Task3.V14.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = { {1, 4, -5, -12, -8 },
                              {-7, -20, 11, -13, 6},
                              {2, -12, 1, -12, 3 },
                              {-1, -7, -20, -6, 17 },
                              {-3, 3, 2, 13, -17 } 
                                                     };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { {1, 4, -5, -12, -8 },
                            {-7, 0, 11, -13, 0},
                            {2, -12, 1, -12, 3 },
                            {-1, -7, -20, -6, 17 },
                            {-3, 3, 2, 13, -17 }
                                                     };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}