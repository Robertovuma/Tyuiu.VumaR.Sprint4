﻿using Tyuiu.VumaR.Sprint4.Task0.V23.Lib;
namespace Tyuiu.VumaR.Sprint4.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int[] nums = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int pr;
            pr = ds.GetMultOddArrEl(nums);
            Console.WriteLine(pr);
            Console.ReadKey();
        }
    }
}
