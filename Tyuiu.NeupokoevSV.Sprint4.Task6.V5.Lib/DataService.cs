using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NeupokoevSV.Sprint4.Task6.V5.Lib
{
    public class DataService : ISprint4Task6V5
    {
        public int Calculate(string[] array)
        {
            string[] a = Array.FindAll(array, x => x.Length == 5);
            return a.Length;
        }
    }
}
