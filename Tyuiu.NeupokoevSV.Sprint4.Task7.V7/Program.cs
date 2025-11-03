using Tyuiu.NeupokoevSV.Sprint4.Task7.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string a = "31415926";
        int n = 4;
        int m = 2;
        int res = ds.Calculate(n, m, a);
        Console.WriteLine(res);
    }
}