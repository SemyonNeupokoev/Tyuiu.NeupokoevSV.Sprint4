using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NeupokoevSV.Sprint4.Task7.V7.Lib
{
    public class DataService : ISprint4Task7V7
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] ma = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ma[i, j] = int.Parse(value.Substring(i * m + j, 1)); 
                }
            }
            int c = 0;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (ma[i, j] % 2 != 0)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}
