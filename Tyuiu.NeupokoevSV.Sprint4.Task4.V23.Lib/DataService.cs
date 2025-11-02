using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NeupokoevSV.Sprint4.Task4.V23.Lib
{
    public class DataService : ISprint4Task4V23
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.Length / rows;
            int s = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        s += matrix[i, j];
                    }
                }
            }
            return s;
        }
    }
}
