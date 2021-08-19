using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ №1
            Console.WriteLine("ДЗ №1");
            Console.Write("Введите размер массива: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[d];
            double sum = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                int el = Convert.ToInt32(Console.ReadLine());
                mas[i] = el;
                sum += mas[i];
            }
            Console.WriteLine($"Наибольшее значение массива: {mas.Max()}");
            Console.WriteLine($"Наименьшее значение массива: {mas.Min()}");
            Console.WriteLine($"Сумма всех элементов: {sum}");
            Console.WriteLine($"Среднее арифметическое значение всех элементов: {sum / mas.Length}");
            for (int i = 0; i < mas.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("Все нечетные значения: ");
                }
                if (mas[i] % 2 != 0)
                {
                    Console.Write($"{mas[i]}, ");
                }
            }
            Console.WriteLine();

            // ДЗ №2
            Console.WriteLine("ДЗ №2");
            Console.Write("Введите размер массива: ");
            int r = int.Parse(Console.ReadLine());
            int[] myArroy = new int[r];
            for (int i = 0; i < myArroy.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                myArroy[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < myArroy.Length; i++)
            {
                if (i == 0) Console.Write($"Элементи первого массива: ");
                Console.Write($"{myArroy[i]}, ");
            }
            Console.WriteLine();
            for (int i = myArroy.Length - 1; i >= 0; i--)
            {
                if (i == myArroy.Length - 1)
                {
                    Console.Write($"Элементи второго массива: ");
                }
                Console.Write($"{myArroy[i]}, ");
            }
            Console.WriteLine();

            // ДЗ №3
            Console.WriteLine("ДЗ №3");
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                array1[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("Элементи первого массива: ");
                }
                Console.Write($"{array1[i]}, ");
            }
            Console.WriteLine();
            Console.Write("Введите размер второго массива: ");
            int count = int.Parse(Console.ReadLine());
            int[] array2 = new int[count];
            Console.Write("Введите индекс массива: ");
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < array2.Length; i++)
            {
                if (index < array1.Length)
                {
                    array2[i] = array1[index];
                    index++;
                }
                if (array2[i] == 0) array2[i] += 1;
                if (i == 0) Console.Write("Элементи второго массива: ");
                Console.Write($"{array2[i]}, ");
            }
        }
    }
}
