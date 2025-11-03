using Tyuiu.NeupokoevSV.Sprint4.Task6.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string[] a = { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
        int res = ds.Calculate(a);
        Console.WriteLine(res);

    }
}