using Tyuiu.NeupokoevSV.Sprint4.Task5.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int len;
        len = Convert.ToInt32(Console.ReadLine());
        int[,] nums = new int[len, len];
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                nums[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        int res = ds.Calculate(nums);
        Console.WriteLine("res");
        Console.WriteLine(res);
    }
}