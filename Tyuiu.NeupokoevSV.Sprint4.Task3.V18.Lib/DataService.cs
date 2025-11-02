using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NeupokoevSV.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0) + 1;
            int cols = array.Length / rows;
            int m = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[4, j] >= m)
                    {
                        m = array[4, j];
                    }
                }
            }
            return m;
        }
    }
}
