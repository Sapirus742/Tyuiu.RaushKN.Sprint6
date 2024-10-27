using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RaushKN.Sprint6.Task3.V14.Lib
{
    public class DataService : ISprint6Task3V14
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length/rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[1,j] % 2 == 0)
                            matrix[1,j] = 0;
                }
            }

            return matrix;
        }
    }
}
