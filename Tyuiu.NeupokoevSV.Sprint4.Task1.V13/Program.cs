using Tyuiu.NeupokoevSV.Sprint4.Task1.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int len;
        len = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        //for (int i = 0; i <= len - 1; i++)
        //{
        //    Console.Write(nums[i] + "\t");
        //}
        Console.WriteLine();
        Console.WriteLine();
        int res = ds.Calculate(nums);
        Console.WriteLine("res");
        Console.WriteLine(res);
    }
}