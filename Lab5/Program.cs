using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сформировать одномерный массив из 7 элементов.
            Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.*/
            int[] array = new int[7];
            int S = 0;
            Console.WriteLine("Количество элементов массива - 7");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
                S += array[i];
            }

            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.Write("Среднее арифметическое: ");
            Console.WriteLine("{0,8:f2}", S / 7);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
