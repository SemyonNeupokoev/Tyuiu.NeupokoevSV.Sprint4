using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NeupokoevSV.Sprint4.Task0.V24.Lib
{
    public class DataService : ISprint4Task0V24
    {
        public int GetMultEvenArrEl(int[] array)
        {
            array = new int[] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int c = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    c *= array[i];
                }
            }
            return c;
        }
    }
}
