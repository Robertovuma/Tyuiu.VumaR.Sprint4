using Tyuiu.VumaR.Sprint4.Task3.V11.Lib;

namespace Tyuiu.VumaR.Sprint4.Task3.V11
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


            int[,] numArry = new int[5, 5] { {8, 6, 9, 4, 5 },
                                           { 9, 4, 8, 5, 6 },
                                           { 9, 7, 9, 8, 4 },
                                           { 4, 6, 5, 7, 8 },
                                           { 6, 6, 7, 6, 4 } };



            Console.WriteLine("Массив: ");
            for (int i = 0; i < numArry.GetLength(0); i++)
            {
                for (int j = 0; j < numArry.GetLength(1); j++)
                {
                    Console.Write($"{numArry[i, j]} \t");
                }
            }
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Kоличество нечетных элементов массива: " + ds.Calculate(numArry));

            Console.ReadKey();
        }
    }
}
