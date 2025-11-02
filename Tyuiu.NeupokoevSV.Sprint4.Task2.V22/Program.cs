using Tyuiu.NeupokoevSV.Sprint4.Task2.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int len;
        len = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[len];
        for (int i = 0; i < len; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        int res = ds.Calculate(nums);
        Console.WriteLine("res");
        Console.WriteLine(res);
    }
}