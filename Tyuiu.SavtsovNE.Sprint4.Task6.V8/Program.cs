﻿using Tyuiu.SavtsovNE.Sprint4.Task6.V8.Lib;
namespace Tyuiu.SavtsovNE.Sprint4.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: | Савцов Никита Евгеньевич ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: | Савцов Никита Евгеньевич ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Пицца\", \"Борщ\", \"Пельмени\",         *");
            Console.WriteLine("* \"Омлет\", \"Салат\", \"Суп\", \"Роллы\"], используя класс Array,       *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 4 символов.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] dishes = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < dishes.Length; i++)
            {
                Console.WriteLine(dishes[i]);
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Слова которые имеют больше 4 символов: ");
            string[] result = ds.Calculate(dishes);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}