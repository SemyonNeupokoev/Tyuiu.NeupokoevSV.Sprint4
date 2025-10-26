using Tyuiu.NeupokoevSV.Sprint4.Task0.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Неупокоев С. В.| ПИНб-25-1";
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int[] array = new int[] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
        Console.WriteLine(ds.GetMultEvenArrEl(array));
    }
}