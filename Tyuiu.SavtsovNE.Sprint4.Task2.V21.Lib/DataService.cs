﻿using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SavtsovNE.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    p *= array[i];
                }
            }
            return p;
        }
    }
}