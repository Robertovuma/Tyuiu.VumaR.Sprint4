﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VumaR.Sprint4.Task1.V22.Lib
{
    public class DataService : ISprint4Task1V22
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    res *= array[i];
                }
            }
            return res; ;
        }
    }
}
