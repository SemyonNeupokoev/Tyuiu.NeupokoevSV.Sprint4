using Tyuiu.NeupokoevSV.Sprint4.Task4.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] data = new int[5, 5] { { 8, 7, 5, 8, 7 }, { 8, 3, 3, 6, 4 }, { 4, 4, 5, 5, 4 }, { 3, 4, 7, 7, 3 }, { 6, 8, 3, 6, 7 } };
        int res = ds.Calculate(data);
        Console.WriteLine(res);
    }
}