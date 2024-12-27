using Tyuiu.VumaR.Sprint4.Task5.V30.Lib;
namespace Tyuiu.VumaR.Sprint4.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            Random random = new Random();

            int[,] arr = new int[5, 5];

            Console.WriteLine("Массив случайных чисел от -2 до 4:");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-2, 5);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }






            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Сумма положительных элементов массива = " + ds.Calculate(arr));







            Console.ReadLine();
        }
    }
}
