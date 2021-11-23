using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN 
            int[] array = new int[5];
            
            Console.WriteLine("Количество элементов массива - 5");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
                
            }
            //Если число четное, будет 1 0 1 0 1; нечетное - 0 1 0 1 0
            Console.WriteLine();
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("1 0 1 0 1");
                }
                else
                {
                    Console.WriteLine("0 1 0 1 0");
                }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
