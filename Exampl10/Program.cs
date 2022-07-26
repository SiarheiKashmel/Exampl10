using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива:");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
           
            for (int i = 0; i < array.Length; i++)
            {
               
                Console.Write($" Введите значение для элемента: [{i}], ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Спасибо массив заполнен!");

        
            var posNums = array.Where(n => n > 0);
            Console.WriteLine($"\nКол-во положительных элементов массива {posNums.LongCount()} ");

            var oddNums = array.Where(t => t % 2 != 0);
            Console.WriteLine($"\nСумма нечетных элементов массва :  {oddNums.Sum()} ");
        }
    }
}