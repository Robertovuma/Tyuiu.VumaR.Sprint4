using Tyuiu.VumaR.Sprint4.Task2.V22.Lib;
namespace Tyuiu.VumaR.Sprint4.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");
            Random rnd = new Random();
            int[] nums = new int[13];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 6 + 1);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(nums);
            Console.WriteLine(res);

        }
    }
}
